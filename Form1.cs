namespace BlackjackCount
{
    public partial class Form1 : Form
    {
        // Tab 1
        private int scoreTab1 = 0;
        // Tab2
        private int scoreTab2 = 0;
        private int[] cardArray= new int[13];
        private Boolean arrayIsInitialized = false;
        private int decksInUse = 3;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        
        public void initArray() 
        {
            if (! arrayIsInitialized) 
            {
                for (int i = 0; i < cardArray.Length; i++) 
                {
                    cardArray[i] = decksInUse * 4;
                }  
                arrayIsInitialized = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: decksInUse = 1; return;
                case 1: decksInUse = 2; return;
                case 2: decksInUse = 3; return;
                case 3: decksInUse = 4; return;
                case 4: decksInUse = 5; return;
                case 5: decksInUse = 6; return;
            }
            init();
        }


        public int accessArray(string card)
        {
            switch (card) 
            {
                case "2" : return cardArray[0];
                case "3" : return cardArray[1];
                case "4" : return cardArray[2];
                case "5" : return cardArray[3];
                case "6" : return cardArray[4];
                case "7" : return cardArray[5];
                case "8" : return cardArray[6];
                case "9" : return cardArray[7];
                case "10": return cardArray[8];
                case "J" : return cardArray[9];
                case "Q" : return cardArray[10];
                case "K" : return cardArray[11];
                case "A" : return cardArray[12];
                default  : return 0;
            }                       
        }

        public void manipulateArray(string card) 
        {
            switch (card)
            {
                case "2":  cardArray[0]--;  return;
                case "3":  cardArray[1]--;  return;
                case "4":  cardArray[2]--;  return;
                case "5":  cardArray[3]--;  return;
                case "6":  cardArray[4]--;  return;
                case "7":  cardArray[5]--;  return;
                case "8":  cardArray[6]--;  return;
                case "9":  cardArray[7]--;  return;
                case "10": cardArray[8]--;  return;
                case "J":  cardArray[9]--;  return;
                case "Q":  cardArray[10]--; return;
                case "K":  cardArray[11]--; return;
                case "A":  cardArray[12]--; return;                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void manipulateScoreTab2(int k) 
        {
            if (k == 1)
            {
                scoreTab2++;
            }
            else scoreTab2--;
        }

        public void init()
        {
            arrayIsInitialized = false;
            scoreTab2 = 0;
            initArray();
            label4.Text = giveScoreTab2();
            label5.Text = "Cards: " + accessArray("2");
            label6.Text = "Cards: " + accessArray("3");
            label7.Text = "Cards: " + accessArray("4");
            label8.Text = "Cards: " + accessArray("5");
            label9.Text = "Cards: " + accessArray("6");
            label10.Text = "Cards: " + accessArray("7");
            label11.Text = "Cards: " + accessArray("8");
            label12.Text = "Cards: " + accessArray("9");
            label13.Text = "Cards: " + accessArray("10");
            label14.Text = "Cards: " + accessArray("J");
            label15.Text = "Cards: " + accessArray("Q");
            label16.Text = "Cards: " + accessArray("K");
            label17.Text = "Cards: " + accessArray("A");
            label1.BringToFront();
            label2.BringToFront();
        }
      

        /**
         * Tab 1 -> Classic
         */

        public void manipulatePictureBoxTab1() 
        {
        
                if (scoreTab1 < -4) pictureBox1.Image = Properties.Resources.score0;
                else if (scoreTab1 > 4) pictureBox1.Image = Properties.Resources.score2;
                else pictureBox1.Image = Properties.Resources.score1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scoreTab1++;
            label1.Text = giveScoreTab1();
            manipulatePictureBoxTab1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = giveScoreTab1();
            manipulatePictureBoxTab1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scoreTab1--;
            label1.Text = giveScoreTab1();
            manipulatePictureBoxTab1();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            scoreTab1 = 0;
            label1.Text = giveScoreTab1();
            manipulatePictureBoxTab1();
        }

        /**
         * Tab 2 -> Advanced
         */

        private void button4_Click(object sender, EventArgs e)
        {
            manipulateArray("2");
            manipulateScoreTab2(1);
            label5.Text = "Cards: " + accessArray("2");
            label4.Text = giveScoreTab2();          

        }

        private void button17_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            manipulateArray("3");
            manipulateScoreTab2(1);
            label6.Text = "Cards: " + accessArray("3");
            label4.Text = giveScoreTab2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manipulateArray("4");
            manipulateScoreTab2(1);
            label7.Text = "Cards: " + accessArray("4");
            label4.Text = giveScoreTab2();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            manipulateArray("5");
            manipulateScoreTab2(1);
            label8.Text = "Cards: " + accessArray("5");
            label4.Text = giveScoreTab2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            manipulateArray("6");
            manipulateScoreTab2(1);
            label9.Text = "Cards: " + accessArray("6");
            label4.Text = giveScoreTab2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            manipulateArray("7");
            label10.Text = "Cards: " + accessArray("7");
            label4.Text = giveScoreTab2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            manipulateArray("8");
            label11.Text = "Cards: " + accessArray("8");
            label4.Text = giveScoreTab2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            manipulateArray("9");
            label12.Text = "Cards: " + accessArray("9");
            label4.Text = giveScoreTab2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            manipulateArray("10");
            manipulateScoreTab2(2);
            label13.Text = "Cards: " + accessArray("10");
            label4.Text = giveScoreTab2();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            manipulateArray("J");
            manipulateScoreTab2(2);
            label14.Text = "Cards: " + accessArray("J");
            label4.Text = giveScoreTab2();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            manipulateArray("Q");
            manipulateScoreTab2(2);
            label15.Text = "Cards: " + accessArray("Q");
            label4.Text = giveScoreTab2();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            manipulateArray("K");
            manipulateScoreTab2(2);
            label16.Text = "Cards: " + accessArray("K");
            label4.Text = giveScoreTab2();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            manipulateArray("A");
            manipulateScoreTab2(2);
            label17.Text = "Cards: " + accessArray("A");
            label4.Text = giveScoreTab2();
        }


        private string giveScoreTab1()
        {
            return scoreTab1 > 0 ? "+" + scoreTab1 : scoreTab1.ToString();
        }

        private string giveScoreTab2()
        {
            return scoreTab2 > 0 ? "+" + scoreTab2 : scoreTab2.ToString();
        }

       
    }
}