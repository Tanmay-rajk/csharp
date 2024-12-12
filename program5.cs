dotnet add package System.Windows.Forms

<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">
  <PropertyGroup>
    <OutputType>WinExe</OutputType>
    <TargetFramework>net6.0-windows</TargetFramework>
    <UseWindowsForms>true</UseWindowsForms>
  </PropertyGroup>
</Project>

#########
using System;
using System.Windows.Forms;
namespace WindowsFormsApp
{
public class MainForm : Form
{
// Declare controls
private Label label;
private TextBox textBox;
private Button button;
public MainForm()
{
// Initialize the controls
label = new Label();
textBox = new TextBox();
button = new Button();
// Set the properties of the Label
label.Text = "Enter your name:";
label.Location = new System.Drawing.Point(20, 20);
label.AutoSize = true;
// Set the properties of the TextBox
textBox.Location = new System.Drawing.Point(20, 50);
textBox.Width = 200;
// Set the properties of the Button
button.Text = "Submit";
button.Location = new System.Drawing.Point(20, 80);
button.Click += new EventHandler(Button_Click);
// Add controls to the form
Controls.Add(label);
Controls.Add(textBox);
Controls.Add(button);
// Set the properties of the Form
this.Text = "Label, TextBox, and Button Example";
this.StartPosition = FormStartPosition.CenterScreen;
this.Size = new System.Drawing.Size(300, 200);
}
// Event handler for the button click event
private void Button_Click(object sender, EventArgs e)
{
// Display the text from the TextBox in the Label
label.Text = $"Hello, {textBox.Text}!";
}
[STAThread]
static void Main()
{
// Run the application
Application.EnableVisualStyles();
Application.Run(new MainForm());
}
}
}
