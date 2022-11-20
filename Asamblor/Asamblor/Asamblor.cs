namespace Asamblor
{
    public partial class Asamblor : Form
    {
        public Asamblor()
        {
            InitializeComponent();
            FillTheDictionary();
        }
        
        public static string fileContent = string.Empty;
        public static int RowCounter = 0;
        string filePath = string.Empty;
        List<ushort> binFile = new();
        Dictionary<string, Attributes> instructions = new();

        private void Asamblor_Load(object sender, EventArgs e)
        {

        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)//Files...
        {

        }

        private void executionToolStripMenuItem_Click(object sender, EventArgs e)//Execution...
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)//Open...
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "asm files (*.asm)|*.asm|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            fileContent = fileContent.ToUpper();
            if (string.IsNullOrEmpty(filePath))
            {
                mainBox.Text = "An error at reading the file occured, please try again!";
                return;
            }
            Parse();
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)//Compile...
        {
            if (string.IsNullOrEmpty(filePath))
            {
                mainBox.Text = "An error at writing the file occured, please try again!";
                return;
            }
            string newPath = filePath + "\\compilat.bin";
            using (FileStream fs = new FileStream(newPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (BinaryWriter b = new BinaryWriter(fs))
                {
                    foreach (ushort bin in binFile)
                    {
                        b.Write(bin);
                    }
                }
            }
            mainBox.Text = "Compiled ! Check The File!";
        }

        private void writeOutToolStripMenuItem_Click(object sender, EventArgs e)//Write Out...
        {
            mainBox.Text = filePath + Environment.NewLine + Environment.NewLine + fileContent;
        }

        private void openEmulatorToolStripMenuItem_Click(object sender, EventArgs e)//Open Emulator
        {
            Emulator emu = new Emulator();
            emu.Visible = true;
            emu.Show();
            this.Hide();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Parse()
        {
            string[] Rows = fileContent.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            fileContent = string.Empty;
            foreach (string Row in Rows)
            {
                if (!(Row.Length == 0 || Row == string.Empty || Row[0] == ';' || Row[0] == '.'))//ce nu trebuie sa fie ca sa intre ca si o linie de cod
                {
                    string[] RowToAnalyse = Row.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (instructions.ContainsKey(RowToAnalyse[0])) //Cazul cand am instructiune
                    {
                        fileContent = fileContent + Row + Environment.NewLine;
                        int cls = instructions[RowToAnalyse[0]].instructionClass; //Clasa instructiunii curente
                        string Opecode = instructions[RowToAnalyse[0]].bin; //Opcodul instructiunii curente
                        string Operands = string.Empty;
                        string Instruction = string.Empty;
                        string[] offset = { "0000000000000000", "0000000000000000" };
                        ushort off = 0;
                        Instruction = Opecode;
                        if (cls != 4)
                        {
                            Operands = DasOperand(RowToAnalyse[1], cls, ref offset); //Operandul/-zi instructiunii curente
                            Instruction = Instruction + Operands;
                        }
                        Instruction = ExtractEmpty(Instruction);
                        ushort bin = Convert.ToUInt16(Instruction, 2);
                        binFile.Add(bin);

                        offset[0] = ExtractEmpty(offset[0]);
                        off = Convert.ToUInt16(offset[0], 2);
                        binFile.Add(off);

                        offset[1] = ExtractEmpty(offset[1]);
                        off = Convert.ToUInt16(offset[1], 2);
                        binFile.Add(off);
                    }
                    else //Cazul cand am altceva nu instructiune
                    {

                    }
                    RowCounter++;
                }
            }
            ConsoleOut();
        }

        private string FillEmpty(string offset) 
        {
            while (offset.Length < 16) 
            {
                offset = "0" + offset;
            }
            return offset;
        }

        private string ExtractEmpty(string Given)
        {
            if (Given != "0000000000000000")
            {
                while (Given[0] != '1')
                {
                    Given = Given.Substring(1);
                }
            }
            return Given;
        }

        private string DasOperand(string Data, int cls, ref string[] offset)
        {
            string op = string.Empty;
            string[] Operands = Data.Split(',', StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            foreach (string Operand in Operands)
            {
                if (!Operand.Contains('R')) //adresare imediata -> 00
                {
                    string register = StringToBinary(Operand);
                    register = FillSpacesOperand(register, cls);
                    op = op + "00" + register;
                }
                if (Operand.Contains('R') && !(Operand.Contains('(') || Operand.Contains(')'))) //adresare directa -> 01
                {
                    string register = Operand.Substring(1);
                    register = register + "D";
                    register = StringToBinary(register);
                    register = FillSpacesOperand(register, cls);
                    op = op + "01" + register;
                }
                if(Operand.Contains('(') && Operand.Contains(')')) //adresare indirecta sau indexata
                {
                    char[] delimiters = { '(', ')' };
                    string[] Fraction = Operand.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    string register = Fraction[0].Substring(1);
                    register = register + "D";
                    register = StringToBinary(register);
                    register = FillSpacesOperand(register, cls);
                    if (Fraction.Length == 1) //adresare indirecta -> 10
                    {
                        register = "10" + register;
                    }
                    if(Fraction.Length == 2) //adresare indexata -> 11
                    {
                        register = "11" + register;
                        offset[i] = Fraction[1];
                        offset[i] = StringToBinary(offset[i]);
                    }
                    op = op + register;
                }
                i++;
            }
            return op;
        }

        private string FillSpacesOperand(string register, int cls) 
        {
            if(cls == 1) 
            {
                while(register.Length < 4) 
                {
                    register = "0" + register;
                }
            }
            if(cls == 2) 
            {
                while (register.Length < 4)
                {
                    register = "0" + register;
                }
            }
            if(cls == 3) 
            {
                while (register.Length < 8)
                {
                    register = "0" + register;
                }
            }
            return register;
        }

        private string StringToBinary(string op) 
        {
            int len = op.Length;
            uint temp = 0;
            if (op.Substring(len - 1, 1) == "B") 
            {
                temp = Convert.ToUInt32(op.Substring(0, len - 1), 2);
            }
            if (op.Substring(len - 1, 1) == "O") 
            {
                temp = Convert.ToUInt32(op.Substring(0, len - 1), 8);
            }
            if (op.Substring(len - 1, 1) == "D") 
            {
                temp = Convert.ToUInt32(op.Substring(0, len - 1), 10);
            }
            if (op.Substring(len - 1, 1) == "H") 
            {
                temp = Convert.ToUInt32(op.Substring(0, len - 1), 16);
            }
            return Convert.ToString(temp, 2);
        }

        private void ConsoleOut() 
        {
            string temp = fileContent + Environment.NewLine;
            foreach(ushort bin in binFile) 
            {
                string s = Convert.ToString(bin, 2);
                string t = Convert.ToString(bin, 16);
                s = FillEmpty(s);
                t = t.ToUpper();

                temp = temp + s + " -> 0x" + t + " len: " + s.Length.ToString() + Environment.NewLine;
            }
            mainBox.Text = temp;
        }

        private void FillTheDictionary()
        {
            //B1 = 4
            instructions.Add("MOV", new Attributes(1, 0, "0000"));
            instructions.Add("ADD", new Attributes(1, 1, "0001"));
            instructions.Add("SUB", new Attributes(1, 2, "0010"));
            instructions.Add("CMP", new Attributes(1, 3, "0011"));
            instructions.Add("AND", new Attributes(1, 4, "0100"));
            instructions.Add("XOR", new Attributes(1, 5, "0101"));
            instructions.Add("OR", new Attributes(1, 6, "0110"));
            //B2 = 8
            instructions.Add("BR", new Attributes(2, 128, "10000000"));
            instructions.Add("BNE", new Attributes(2, 129, "10000001"));
            instructions.Add("BEQ", new Attributes(2, 130, "10000010"));
            instructions.Add("BPL", new Attributes(2, 131, "10000011"));
            instructions.Add("BMI", new Attributes(2, 132, "10000100"));
            instructions.Add("BCS", new Attributes(2, 133, "10000101"));
            instructions.Add("BCC", new Attributes(2, 134, "10000110"));
            instructions.Add("BVS", new Attributes(2, 135, "10000111"));
            instructions.Add("BVC", new Attributes(2, 136, "10001000"));
            instructions.Add("JMP", new Attributes(2, 137, "10001001"));
            //B3 = 10
            instructions.Add("CLR", new Attributes(3, 768, "1100000000"));
            instructions.Add("NEG", new Attributes(3, 769, "1100000001"));
            instructions.Add("INC", new Attributes(3, 770, "1100000010"));
            instructions.Add("DEC", new Attributes(3, 771, "1100000011"));
            instructions.Add("ASL", new Attributes(3, 772, "1100000100"));
            instructions.Add("ASR", new Attributes(3, 773, "1100000101"));
            instructions.Add("LSR", new Attributes(3, 774, "1100000110"));
            instructions.Add("ROL", new Attributes(3, 775, "1100000111"));
            instructions.Add("ROR", new Attributes(3, 776, "1100001000"));
            instructions.Add("RLC", new Attributes(3, 777, "1100001001"));
            instructions.Add("RRC", new Attributes(3, 778, "1100001010"));
            instructions.Add("PUSH", new Attributes(3, 779, "1100001011"));
            instructions.Add("POP", new Attributes(3, 780, "1100001100"));
            instructions.Add("CALL", new Attributes(3, 781, "1100001101"));
            //B4 = 16
            instructions.Add("CLC", new Attributes(4, 57344, "1110000000000000"));
            instructions.Add("CLV", new Attributes(4, 57345, "1110000000000001"));
            instructions.Add("CLZ", new Attributes(4, 57346, "1110000000000010"));
            instructions.Add("CLS", new Attributes(4, 57347, "1110000000000011"));
            instructions.Add("CCC", new Attributes(4, 57348, "1110000000000100"));
            instructions.Add("SEC", new Attributes(4, 57349, "1110000000000101"));
            instructions.Add("SEV", new Attributes(4, 57350, "1110000000000110"));
            instructions.Add("SEZ", new Attributes(4, 57351, "1110000000000111"));
            instructions.Add("SES", new Attributes(4, 57352, "1110000000001000"));
            instructions.Add("SCC", new Attributes(4, 57353, "1110000000001001"));
            instructions.Add("NOP", new Attributes(4, 57354, "1110000000001010"));
            instructions.Add("RET", new Attributes(4, 57355, "1110000000001011"));
            instructions.Add("RETI", new Attributes(4, 57356, "1110000000001100"));
            instructions.Add("HALT", new Attributes(4, 57357, "1110000000001101"));
            instructions.Add("WAIT", new Attributes(4, 57358, "1110000000001110"));
            instructions.Add("PUSH_PC", new Attributes(4, 57359, "1110000000001111"));
            instructions.Add("POP_PC", new Attributes(4, 57360, "1110000000010000"));
            instructions.Add("PUSH_FLAG", new Attributes(4, 57361, "1110000000010001"));
            instructions.Add("POP_FLAG", new Attributes(4, 57362, "1110000000010010"));
        }
    }
}