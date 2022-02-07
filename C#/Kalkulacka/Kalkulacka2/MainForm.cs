using System;
using System.Windows.Forms;
using System.Linq;


namespace Kalkulacka
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private double num = 0;			// zadané číslo
		private string operation;		// znak operace
		private bool clicked = false;	// kliknuto na operator

				
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		// kliknutí na číselné tlačítko
		private void Button_click(object sender, EventArgs e) 
		{
			if((textBox.Text == "0") || (clicked))
				textBox.Clear();						// vyčiští textbox před zadáním nového čísla
			clicked = false;	
			
			Button button = (Button)sender;
			
			if(button.Text.Equals(",")) {						// ošetření desetinné čárky
			   	if(!textBox.Text.Contains(","))
			   		textBox.Text = textBox.Text + button.Text;   
		   	} else 
				textBox.Text = textBox.Text + button.Text;   	
		}
		
		
		// kliknutí na desetinnou čárku
		private void ButtonComma_click(object sender, EventArgs e) 
		{
			if (!textBox.Text.Contains(","))
         	   textBox.Text = textBox.Text + "," ;
		}

		
		// klik na CE button	
		private void ButtonCEClick(object sender, EventArgs e)
		{
			Symbol.Text = "";			// smaže symbol matematické operace v labelu
			textBox.Text = "0";
			num = 0;		
		}
		
	
		//smaže poslední zadané číslo
		private void ButtonBackClick(object sender, EventArgs e)
		{
			// nejde do záporných hodnot
			if(textBox.Text != "") {
	           textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
			}
			//když je v textboxu jen jedno číslo - po smazání nahradí defaultní nulou
			if (textBox.Text.Length == 0) {			//
				textBox.Text = "0";
			}
		}
		
		
		// kliknutí na rovná se
		private void ButtonEqualClick(object sender, EventArgs e) 
		{
			switch(operation){
				case "+":
					textBox.Text = (num + Convert.ToDouble(textBox.Text)).ToString();
					break;
				case "-":
					textBox.Text = (num - Convert.ToDouble(textBox.Text)).ToString();
					break;
				case "*":
					textBox.Text = (num * Convert.ToDouble(textBox.Text)).ToString();
					break;
				case "÷":
					if (textBox.Text == "0")	{ 		//dělení nulou
						MessageBox.Show("Nelze dělit nulou !");
					} else {
						textBox.Text = (num / Convert.ToDouble(textBox.Text)).ToString();
					}
					break;
				case ("x²"):	// druhá mocnina
					textBox.Text = Math.Pow(Convert.ToDouble(textBox.Text), 2).ToString();
					break;
				case ("√x"):	// druhá odmocnina
					textBox.Text = Math.Sqrt(Convert.ToDouble(textBox.Text)).ToString();
					break;
				default:
					break;
			} 
			num = Convert.ToDouble(textBox.Text);			// uložení čísla do num
			operation = "";				// vynulování operace				
		}
				
		
		// kliknbutí na tlačítka operací
		private void ButtonOperation_click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			
			if(num !=0) {
				buttonEquals.PerformClick();
				clicked = true;
				operation = button.Text;	
				ShowOperator(sender, e);
			} else	{
				operation = button.Text;			// přiřazení znaménka operace do stringu
				num = Convert.ToDouble(textBox.Text);			// přiřazení čísla
				clicked = true;
				ShowOperator(sender, e);
			}
		}
				
		
		// zobrazení znaménko operace na labelu Symbol
		private void ShowOperator(object sender, EventArgs e) 
		{
			Button button = (Button)sender;
			
			switch(button.Text) {
				case ("+"):
				case ("-"):
				case ("*"):					
				case ("÷"):
				case ("x²"):	
				case ("√x"):					
					Symbol.Text = button.Text;
					break;
			}
		}

	}
}
		

	
			
		

