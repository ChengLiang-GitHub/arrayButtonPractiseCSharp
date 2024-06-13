using System.Reflection;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] g = { "Mouse", "Cow", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Chicken", "Dog", "Pig" };

        private int findMap(string path)
        {
            int i;
            for (i = 0; i < g.Length; i++)
            {
                if (path.Contains(g[i]))
                    return i;
            }
            return -1;
        }

        Dictionary<int, string> img256PixelMap = new Dictionary<int, string>();
        Dictionary<int, string> img72PixelMap = new Dictionary<int, string>();
        void createMap(string directoryPath, Dictionary<int, string> imgXXPixelMap)
        {
            if (Directory.Exists(directoryPath))
            {
                // Get the list of files in the directory
                string[] allFilePath = Directory.GetFiles(directoryPath);

                // Display the list of files

                foreach (var aMap in allFilePath.Select((aFilePath, pathIndex) => new { animalIndex = findMap(aFilePath), aFilePath }))
                {
                    imgXXPixelMap.Add(aMap.animalIndex, aMap.aFilePath);

                }
                for (int i = 0; i < imgXXPixelMap.Count; i++)
                {
                    testRTB.Text += $"animal index={i} file path={imgXXPixelMap[i]} \n";
                }
                //foreach (string aFilePath in allFilePath)
                //{
                //    string[] eachFile = aFilePath.Split("\\");
                //    foreach(string aFile in eachFile )
                //        for(int i = 0; i < g.Length; i++)
                //            if (aFile.Contains(g[i]))
                //                testRTB.Text += aFile + "\n";
                //}
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testRTB.Text = "Files in the directory:\n";
            createMap("..\\..\\..\\..\\img256px\\", img256PixelMap);
            createMap("..\\..\\..\\..\\img72px\\", img72PixelMap);
        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            Button[] btn = new Button[12];        //建立3個button 空間
                                                  //


            for (int i = 0; i < btn.Length; i++)
            {
                btn[i] = new Button();
                btn[i].Name = "btn" + i;                                        	//先建立名稱(name 本名)
                btn[i].Text = (i + 1).ToString() + " : " + g[i];
                btn[i].Location = new Point(200 + 180 * (i % 4), 50 + 100 * (i / 4));            	//指定位置
                btn[i].Size = new Size(130, 80);
                btn[i].Image = Image.FromFile(img72PixelMap[i]);
                btn[i].ImageAlign = ContentAlignment.MiddleRight;
                btn[i].TextAlign = ContentAlignment.MiddleLeft;
                btn[i].Click += btn_Click;

            }
            showTP.Controls.AddRange(btn);
        }
        void btn_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            //MessageBox.Show(sTrip);
            //MessageBox.Show("" + s.ToCharArray()[0] + " " + Convert.ToInt32(s.ToCharArray()[0]));
            string numStr="";

            foreach(char c in s)
            {
                if (c == ':' | c == ' ')
                    break;
                else
                    numStr += c;
            }
            pictureBox1.Image = Image.FromFile(img256PixelMap[Int32.Parse(numStr)-1]);
        }


        private void testBTN_Click(object sender, EventArgs e)
        {

            testRTB.Text += Int32.Parse("100");
        }
    }
}
