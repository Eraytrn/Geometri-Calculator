namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        /* {
             // Kare Alani Hesaplama
             int kareKenarUzunluk = Convert.ToInt32(textBoxKenar.Text);
             int alanKare = kareKenarUzunluk * kareKenarUzunluk;    // Math.Pow(kareKenarUzunluk, 2);
             labelKare.Text = alanKare.ToString();

             // Dikd�rtgen Alan Hesaplama
             double k�saKenarUzunluk = Convert.ToDouble(textBoxK�saKenar.Text);
             double uzunKenarUzunluk = Convert.ToDouble(textBoxUzunKenar.Text);
             double alanDikd�rtgen  = k�saKenarUzunluk * uzunKenarUzunluk;
             labelDikdortgen.Text = alanDikd�rtgen.ToString();

             // Daire Alan Hesaplama
             int yaricap = Convert.ToInt16(textBoxYaricap.Text);
             int alanDaire = (int)Math.PI * (yaricap * yaricap);
             labelDaire.Text = alanDaire.ToString();
         }*/

        {
            //Kare Alan Hesaplama
            int kareKenarUzunluk = Convert.ToInt32(textBoxKenar.Text);
            int alanKare = kareKenarUzunluk * kareKenarUzunluk;
            labelKare.Text = alanKare.ToString();

            //Dikdortgen Alan Hesaplama
            int k�saKenarUzunluk = Convert.ToInt32(textBoxK�saKenar.Text);
            int uzunKenarUzunluk = Convert.ToInt32(textBoxUzunKenar.Text);
            int dikdortgenAlan = k�saKenarUzunluk * uzunKenarUzunluk;
            labelDikdortgen.Text = dikdortgenAlan.ToString();

            //Daire Alan Hesaplama
            int yaricap = Convert.ToInt32(textBoxYaricap.Text);
            int alanDaire = (int)Math.PI * (yaricap * yaricap);
            labelDaire.Text = alanDaire.ToString();


        }

    }
}