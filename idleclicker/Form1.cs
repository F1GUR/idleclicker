namespace idleclicker
{
    public partial class Form1 : Form
    {
        private int cash;
        public int Cash
        {
            set
            {
                cash = value;
                label1.Text = "kasa: $" + value.ToString();
            }
            get { return cash; }           
        }

        int buttonLevel;
        int A1Ammount;
        int A1Interval;
        public Form1()
        {
            InitializeComponent();
            Cash = 0;
            buttonLevel = 1;
            A1Ammount = 10;
            A1Interval = 0;
            A1ammounttextBox.Text = A1Ammount.ToString();
            A1_intervaltextBox.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash+= (int)Math.Pow(10, buttonLevel-1);
            //label1.Text = "Kasa: $" + cash.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if(Cash >= upgradeCost)
            {

                buttonLevel++;
                textBox1.Text = buttonLevel.ToString();
                Cash -= upgradeCost;
                //label1.Text = "Kasa: $" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                button2.Text = "Upgrade\n" + nextUpgradeCost;
            }
        }

        private void A1_UpgradeInterval_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(10, A1Interval);
            if (Cash >= upgradeCost){

                A1Interval++;
                A1_intervaltextBox.Text = A1Interval.ToString();
                A1Timer.Interval = (60 / A1Interval) * 100;


                if (!A1Timer.Enabled)
               
                    A1Timer.Enabled = true;
                    Cash -= upgradeCost;
                string nextUpgradeCost = "($" + Math.Pow(10, A1Interval).ToString() + ")";
                A1_UpgradeInterval.Text = "Ulepsz Czêstotliwoœæ\n" + nextUpgradeCost;

            }
        }

        private void A1klik(object sender, EventArgs e)
        {
            Cash += A1Ammount;
            //label1.Text = "Kasa: $" + cash.ToString();
        }

        private void A1_Upgradeammount_Click(object sender, EventArgs e)
        {
            
            int upgradeCost = (int)Math.Pow(10, buttonLevel);
            if (Cash >= upgradeCost)
            {
                buttonLevel++;
                A1Ammount += 10;
                A1ammounttextBox.Text = A1Ammount.ToString();
                Cash -= upgradeCost;


            //test
                string nextUpgradeCost = "($" + Math.Pow(10, buttonLevel).ToString() + ")";
                A1_Upgradeammount.Text = "Ulepsz Iloœæ\n" + nextUpgradeCost;

            }
        }
    }
}