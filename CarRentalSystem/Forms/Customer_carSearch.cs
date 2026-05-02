namespace try_drag_and_drop;

using System.Collections.Generic;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void lblFilterTitle_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void pnlResults_Paint(object sender, PaintEventArgs e)
    {

    }

    private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
    {

    }

    private void flowCars_Paint(object sender, PaintEventArgs e)
    {

    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        flowCars.Controls.Clear();

        int days = (dtpReturn.Value.Date - dtpPickup.Value.Date).Days;

        if (days <= 0)
        {
            MessageBox.Show("Return date must be after pickup date.");
            return;
        }

        var cars = new List<CarCardControl>()
{
    new CarCardControl("Toyota Camry 2023", "Sedan", "5 seats", "Automatic", "Cairo - Nasr City", 650, days, "images/toyota.jpg"),
    new CarCardControl("Hyundai Tucson 2022", "SUV", "5 seats", "Automatic", "Cairo - Maadi", 900, days, "images/hyundai tucson.jpg"),
    new CarCardControl("Mercedes C-Class 2023", "Luxury", "5 seats", "Automatic", "Giza", 1800, days, "images/mercedes.jpg"),
    new CarCardControl("Kia Sportage 2024", "SUV", "5 seats", "Manual", "Cairo - Nasr City", 850, days, "images/kia.jpg")
};
        foreach (var car in cars)
        {
            car.Margin = new Padding(10);
            flowCars.Controls.Add(car);
        }
    }
}