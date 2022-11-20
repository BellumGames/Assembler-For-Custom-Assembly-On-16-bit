using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asamblor
{
    public partial class Emulator : Form
    {
        public Emulator()
        {
            InitializeComponent();
        }

        #region definitions
        public string content = Asamblor.fileContent;
        List<ushort> file = new List<ushort>();
        public static List<byte> fileContent = new List<byte>();
        List<string> microcode = new List<string>();
        string microprogram_string;
        string str;

        static byte[] RAM = new byte[65536];
        static UInt16 IR = 0;
        static UInt16 FLAG = 0;
        static UInt16 IVR = 0;
        static UInt16 T = 0;
        static UInt16 SP = 65534;
        static UInt16 MDR = 0;
        static UInt16 ADR = 0;
        static UInt16 PC = 0;
        static UInt16 PCMax = (ushort)Asamblor.RowCounter;
        static UInt16[] R = new UInt16[16];
        static UInt64[] MPM = new UInt64[200];
        static UInt64 MIR = 0;
        static UInt16 MAR = 0;
        static UInt16 SBUS = 0;
        static UInt16 DBUS = 0;
        static UInt16 RBUS = 0;
        static UInt16 Carry = 0;

        static string registru;
        static int contor;
        static int adresaSalt;
        static int modAdresare;
        static int offset;
        static string valIndex;
        static string valIndexSursa;
        static string valIndexDest;
        static string offsetString;
        #endregion

        private void Emulator_Load(object sender, EventArgs e)
        {

        }

        private void goBackToAssemblerToolStripMenuItem_Click(object sender, EventArgs e)//Go Back To Assembler..
        {
            Asamblor asa = new Asamblor();
            asa.Visible = true;
            asa.Show();
            this.Hide();
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)//Files...
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)//Open...
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] buffer = File.ReadAllBytes(openFileDialog.FileName);
                    ushort i = 0;
                    foreach (byte b in buffer)
                    {
                        RAM[i] = b;
                        fileContent.Add(b);
                        i++;
                    }
                }
            }
            int j = 0;
            for (int i = 0; i < fileContent.Count; i++)
            {
                ushort c = 0;
                if (i % 2 == 0)
                {
                    c = fileContent[i];
                    file.Add(c);
                    j++;
                }
                else
                {
                    c = fileContent[i];
                    c = (ushort)(c << 8);
                    file[j - 1] = (ushort)(file[j - 1] | c);
                }
            }
            instrBox.Text = content;
            /*
            string temp = string.Empty;
            foreach (ushort c in file)
            {
                string l = Convert.ToString(c, 16);
                l = l.ToUpper();
                temp = temp + "0x" + l + Environment.NewLine;
            }
            instrBox.Text = temp;
            */
        }

        private void stepToolStripMenuItem_Click(object sender, EventArgs e)//Step...
        {

        }

        private void runToEndToolStripMenuItem_Click(object sender, EventArgs e)//Run To End...
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)//Reset...
        {
            ResetData();
            ResetForm();
        }

        private void showMemToolStripMenuItem_Click(object sender, EventArgs e)//Show Mem...
        {
            var m = new CPU.Memory();
            m.Visible = true;
            m.Show();
        }

        private void openMicrocodeToolStripMenuItem_Click(object sender, EventArgs e)//Open Microcode...
        {
            LoadMicroCode();
            CreateMicroCodeBin();
            OpenMicroCode();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------

        private void LoadMicroCode()
        {
            StreamReader sr = new StreamReader("micro_program_string.txt");
            while ((str = sr.ReadLine()) != null)
            {
                microcode.Add(str);
            }
            sr.Close();

            string temp = string.Empty;
            foreach (string x in microcode)
            {
                temp = temp + x + Environment.NewLine;
            }
            microBox.Text = temp;
        }

        private void CreateMicroCodeBin()
        {
            string fout = "micro_bin.bin";
            FileStream fs1 = new FileStream(fout, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs1);

            StreamReader sr = new StreamReader("micro_program_bin.txt");

            while ((str = sr.ReadLine()) != null)
            {
                bw.Write(Convert.ToInt64(str, 2));
            }

            sr.Close();
            bw.Close();
        }

        private void OpenMicroCode()
        {
            string fin = "micro_bin.bin";
            FileStream fs2 = new FileStream(fin, FileMode.Open);
            BinaryReader bw = new BinaryReader(fs2);

            int counter = 0;
            int pos = 0;
            Int64 length = (Int64)bw.BaseStream.Length;
            while (pos < length)
            {
                MPM[counter] = bw.ReadUInt64();
                pos += sizeof(UInt64);
                counter++;
            }
        }

        private void ResetData() 
        {
            IR = 0;
            FLAG = 0;
            IVR = 0;
            T = 0;
            SP = 65534;
            MDR = 0;
            ADR = 0;
            PC = 0;
            PCMax = 0;
            MIR = 0;
            MAR = 0;
            SBUS = 0;
            DBUS = 0;
            RBUS = 0;
            Carry = 0;
            for (int i = 0; i < R.Length; i++)
            {
                R[i] = 0;
            }
            for (int i = 0; i < MPM.Length; i++)
            {
                MPM[i] = 0;
            }
        }

        private void ResetForm() 
        {
            IR_R.Text = "0000000000000000";
            FLAG_R.Text = "0000000000000000";
            IVR_R.Text = "0000000000000000";
            T_R.Text = "0000000000000000";
            SP_R.Text = "1111111111111111";
            MDR_R.Text = "0000000000000000";
            ADR_R.Text = "0000000000000000";
            PC_R.Text = "0000000000000000";
            R0_R.Text = "0000000000000000";
            R1_R.Text = "0000000000000000";
            R2_R.Text = "0000000000000000";
            R3_R.Text = "0000000000000000";
            R4_R.Text = "0000000000000000";
            R5_R.Text = "0000000000000000";
            R6_R.Text = "0000000000000000";
            R7_R.Text = "0000000000000000";
            R8_R.Text = "0000000000000000";
            R9_R.Text = "0000000000000000";
            R10_R.Text = "0000000000000000";
            R11_R.Text = "0000000000000000";
            R12_R.Text = "0000000000000000";
            R13_R.Text = "0000000000000000";
            R14_R.Text = "0000000000000000";
            R15_R.Text = "0000000000000000";
        }
    }
}
