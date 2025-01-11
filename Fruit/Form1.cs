using System.Diagnostics.Contracts;

namespace Fruit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Citrus orange = new Citrus();
        Citrus mandarins = new Citrus();

        PomeFruit apple = new PomeFruit();
        PomeFruit pear = new PomeFruit();

        Drupe peach = new Drupe();
        Drupe cherry = new Drupe();

        DehiscentFruit pea = new DehiscentFruit();
        DehiscentFruit bean = new DehiscentFruit();

        IndehiscentFruit almond = new IndehiscentFruit();
        IndehiscentFruit walnut = new IndehiscentFruit();
        IndehiscentFruit corn = new IndehiscentFruit();
        //IndehiscentFruit grain = new IndehiscentFruit();

        AcheneFruit strawberry = new AcheneFruit();

        Drupelets raspberry = new Drupelets();
        Drupelets blackberry = new Drupelets();

        ClusteredFruit pineapple = new ClusteredFruit();

        CompositeFruit fig = new CompositeFruit();
        CompositeFruit mulberry = new CompositeFruit();

        private void button1_Click(object sender, EventArgs e)
        {
            labelListOfFruits.Text = apple.printDef();

        }

        private void listBoxAllFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ListBox
            string selectedFruit = listBoxAllFruits.SelectedItem.ToString();

            //center the labelFruitName label, at the top form (without considering the borders, of course)
            labelFruitName.Left = (this.ClientSize.Width - labelFruitName.Width) / 2;
            labelFruitName.Top = (this.ClientSize.Height) / 10;

            //just center the labelFruitDescription label
            labelFruitDescription.Left = (this.ClientSize.Width - labelFruitDescription.Width) / 2;
            labelFruitDescription.Top = (this.ClientSize.Height - labelFruitDescription.Height) / 2;


            //Was not allowed to use dictionaries
            switch (selectedFruit)
            {
                //display details about the fruit
                case "Orange":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Orange";
                    labelFruitDescription.Text = orange.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Mandarin":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Mandarin";
                    labelFruitDescription.Text = mandarins.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Apple":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Apple";
                    labelFruitDescription.Text = apple.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Pear":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Pear";
                    labelFruitDescription.Text = pear.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Peach":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Peach";
                    labelFruitDescription.Text = peach.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Cherry":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Cherry";
                    labelFruitDescription.Text = orange.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Peas":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Peas";
                    labelFruitDescription.Text = pea.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Beans":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Beans";
                    labelFruitDescription.Text = bean.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Almond":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Almond";
                    labelFruitDescription.Text = almond.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Walnut":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Walnut";
                    labelFruitDescription.Text = walnut.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Corn":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Corn";
                    labelFruitDescription.Text = corn.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Strawberry":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Strawberry";
                    labelFruitDescription.Text = strawberry.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Raspberry":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Raspberry";
                    labelFruitDescription.Text = raspberry.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Blackberry":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Blackberry";
                    labelFruitDescription.Text = blackberry.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Pineapple":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Pineapple";
                    labelFruitDescription.Text = pineapple.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Fig":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Fig";
                    labelFruitDescription.Text = fig.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
                case "Mulberry":
                    labelListOfFruits.Visible = false;
                    listBoxAllFruits.Visible = false;
                    labelPickAFruit.Visible = false;

                    labelFruitName.Text = "Mulberry";
                    labelFruitDescription.Text = mulberry.printDef();

                    labelFruitName.Visible = true;
                    labelFruitDescription.Visible = true;
                    btnListOfFruits.Visible = true;
                    break;
            }
        }
        int count = 0;
        private void btnLight_Click(object sender, EventArgs e)
        {
            //change the text and background colors for light mode
            count++;
            if( count % 2 == 1 )
            {
                //Dark mode
                this.ForeColor = Color.White;
                this.BackColor = Color.Black;

                btnLight.ForeColor = Color.Black;
                btnLight.BackColor = Color.DarkGray;

                listBoxAllFruits.ForeColor = Color.White;
                listBoxAllFruits.BackColor = Color.Black;

                btnListOfFruits.ForeColor = Color.Black;
                btnListOfFruits.BackColor = Color.DarkGray;
            } else
            {
                //Light mode
                this.ForeColor = Color.Black;
                this.BackColor = Color.White;

                btnLight.ForeColor = Color.Black;
                btnLight.BackColor = Color.White;

                listBoxAllFruits.ForeColor = Color.Black;
                listBoxAllFruits.BackColor = Color.White;

                btnListOfFruits.ForeColor = Color.Black;
                btnListOfFruits.BackColor = Color.White;
            }
            
        }

        private void btnListOfFruits_Click(object sender, EventArgs e)
        {
            //switch from list of fruits to details about the fruit
            labelListOfFruits.Visible = true;
            listBoxAllFruits.Visible = true;
            labelPickAFruit.Visible = true;

            labelFruitName.Visible = false;
            labelFruitDescription.Visible = false;
            btnListOfFruits.Visible = false;
        }

        private void btnDark_Click(object sender, EventArgs e)
        {

        }
    }
}
