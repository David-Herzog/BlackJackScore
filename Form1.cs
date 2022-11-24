namespace BlackjackCount
{
    public partial class Form1 : Form
    {
        private int scoreTab1 = 0;

        private int scoreTab2 = 0;
        private int[] cardArray= new int[13];
        private Boolean arrayIsInitialized = false;

        public Form1()
        {
            InitializeComponent();
            initArray();
        }

        
        public void initArray() 
        {
            if (! arrayIsInitialized) 
            {
                for (int i = 0; i < cardArray.Length; i++) 
                {
                    cardArray[i] = 12;
                }  
                arrayIsInitialized = true;
            }
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

      

        /**
         * Tab 1 -> Classic
         */

        private void button1_Click(object sender, EventArgs e)
        {
            scoreTab1++;
            label1.Text = giveScoreTab1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = giveScoreTab1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scoreTab1--;
            label1.Text = giveScoreTab1();
        }


        /**
         * Tab 2 -> Advanced
         */

        private void button4_Click(object sender, EventArgs e)
        {
            manipulateArray("2");
            manipulateScoreTab2(1);
            label5.Text = accessArray("2").ToString();
            label4.Text = giveScoreTab2();

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            manipulateArray("3");
            manipulateScoreTab2(1);
            label6.Text = accessArray("3").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manipulateArray("4");
            manipulateScoreTab2(1);
            label7.Text = accessArray("4").ToString();
            label4.Text = giveScoreTab2();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            manipulateArray("5");
            manipulateScoreTab2(1);
            label8.Text = accessArray("5").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            manipulateArray("6");
            manipulateScoreTab2(1);
            label9.Text = accessArray("6").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            manipulateArray("7");
            label10.Text = accessArray("7").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            manipulateArray("8");
            label11.Text = accessArray("8").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            manipulateArray("9");
            label12.Text = accessArray("9").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            manipulateArray("10");
            manipulateScoreTab2(2);
            label13.Text = accessArray("10").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            manipulateArray("J");
            manipulateScoreTab2(2);
            label14.Text = accessArray("J").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            manipulateArray("Q");
            manipulateScoreTab2(2);
            label15.Text = accessArray("Q").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            manipulateArray("K");
            manipulateScoreTab2(2);
            label16.Text = accessArray("K").ToString();
            label4.Text = giveScoreTab2();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            manipulateArray("A");
            manipulateScoreTab2(2);
            label17.Text = accessArray("A").ToString();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}