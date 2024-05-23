using System;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SCAuctionFetcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ChromeDriver driver = null;
        private string item = "4k5gr";
        private System.Media.SoundPlayer player = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            Deserialize();
            player = new System.Media.SoundPlayer("Sounds/CashSound.wav");
            player.Load();

            //Directory.CreateDirectory("Settings");
            //Directory.CreateDirectory("dll");
            //Directory.CreateDirectory("Sounds");

            if (!File.Exists("Settings/Items.json"))
            {
                File.WriteAllText("Settings/Items.json", "[]");
            }
            if (!File.Exists("Settings/Save.json"))
            {
                File.WriteAllText("Settings/Save.json", "[]");
            }
        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                //var picture = flowLayoutPanel1.Controls[i].Controls[0] as PictureBox;
                //var itemInfo = flowLayoutPanel1.Controls[i].Controls[1].Text;
                //var itemId = flowLayoutPanel1.Controls[i].Controls[1].Tag;
                //var price = flowLayoutPanel1.Controls[i].Controls[2].Text;
                //var priceThreshold = flowLayoutPanel1.Controls[i].Controls[3].Text;
                var timerText = flowLayoutPanel1.Controls[i].Controls[4].Text;
                var timerDefault = flowLayoutPanel1.Controls[i].Controls[4].Tag;

                var timer = Int32.Parse(timerText);

                if (timer > 1)
                {
                    timer--;

                    flowLayoutPanel1.Controls[i].Controls[4].Text = timer.ToString();
                }
                else
                {
                    //-----------------[Chrome Driver]-------------------------------------------------------//
                    driver.SwitchTo().Window(driver.WindowHandles[i]);
                    driver.Navigate().Refresh();

                    var data = driver.FindElement(By.Id("nameCurrentItem"));
                    flowLayoutPanel1.Controls[i].Controls[1].Text = data.GetAttribute("innerText");

                    data = driver.FindElement(By.Id("iconItemData"));
                    (flowLayoutPanel1.Controls[i].Controls[0] as PictureBox).ImageLocation = data.GetAttribute("currentSrc");

                    data = driver.FindElement(By.Id("tempMinPrice"));
                    flowLayoutPanel1.Controls[i].Controls[2].Text = data.GetAttribute("innerText");

                    while (flowLayoutPanel1.Controls[i].Controls[2].Text == "0 RUB")
                    {
                        Thread.Sleep(100);
                        flowLayoutPanel1.Controls[i].Controls[2].Text = data.GetAttribute("innerText");
                    }
                    //---------------------------------------------------------------------------------------//

                    flowLayoutPanel1.Controls[i].Controls[4].Text = timerDefault.ToString(); // Defaulting timer

                    var price = FixThatDamnPriceTag(flowLayoutPanel1.Controls[i].Controls[2].Text);

                    if (!Int32.TryParse(price, out int priceOut)) { }
                    if (!Int32.TryParse(flowLayoutPanel1.Controls[i].Controls[3].Text, out int priceThresholdOut)) { }

                    if (priceOut == 0)
                    {
                        flowLayoutPanel1.Controls[i].BackColor = Color.FromArgb(255, 255, 128);
                    }
                    else if (priceOut <= priceThresholdOut)
                    {
                        //SystemSounds.Hand.Play();
                        player.Play();

                        flowLayoutPanel1.Controls[i].BackColor = Color.FromArgb(128, 0, 0);
                        this.TopMost = true;
                        this.TopMost = false;
                    }
                    else
                    {
                        flowLayoutPanel1.Controls[i].BackColor = Color.FromArgb(40, 40, 40);
                    }
                }
            }
        }

        private void CreatePanelButton_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------[Main Panel]------------------------------------------------//
            Panel panel = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(40, 40, 40),
                Width = 211,
                Height = 125
            };
            //---------------------------------------------------[Picture]--------------------------------------------------//
            PictureBox pictureBox = new PictureBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Gray,
                Location = new Point(3, 3),
                ImageLocation = "https://stalcraft-monitor.ru/db/icons/other/4k5gr.png",
                Width = 64,
                Height = 64
            };
            panel.Controls.Add(pictureBox);
            //---------------------------------------------------[Info Box]-------------------------------------------------//
            TextBox infoBox = new TextBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Gray,
                ForeColor = Color.White,
                Location = new Point(73, 3),
                Width = 133,
                Height = 64,
                Multiline = true,
                TextAlign = HorizontalAlignment.Center,
                Text = "Item Info",
                Tag = idSetBox1.Text,
                ReadOnly = true
            };
            panel.Controls.Add(infoBox);
            //---------------------------------------------------[Price Box]------------------------------------------------//
            TextBox priceBox = new TextBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                Location = new Point(3, 73),
                Width = 133,
                Height = 20,
                TextAlign = HorizontalAlignment.Center,
                Text = "10 000,00 ₽",
                ReadOnly = true
            };
            panel.Controls.Add(priceBox);
            //---------------------------------------------------[Price Threshold Box]--------------------------------------//
            TextBox priceThresholdBox = new TextBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                Location = new Point(3, 99),
                Width = 133,
                Height = 20,
                TextAlign = HorizontalAlignment.Center,
                Text = PriceSetBox1.Text
            };
            panel.Controls.Add(priceThresholdBox);
            //---------------------------------------------------[Timer Box]------------------------------------------------//
            TextBox timerBox = new TextBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.DimGray,
                ForeColor = Color.White,
                Location = new Point(142, 73),
                Width = 64,
                Height = 20,
                TextAlign = HorizontalAlignment.Center,
                Text = timerSetBox1.Text,
                Tag = timerSetBox1.Text,
                ReadOnly = true
            };
            panel.Controls.Add(timerBox);
            //--------------------------------------------------------------------------------------------------------------//
            flowLayoutPanel1.Controls.Add(panel);
            //------------------------------------------------------[Chrome Driver]-----------------------------------------//
            if (driver == null)
            {
                var chromeOptions = new ChromeOptions();
                var chromeDriverService = ChromeDriverService.CreateDefaultService();

                if (checkBoxBrowser.Checked != true)
                {
                    chromeOptions.AddArgument("headless");
                }

                if (checkBoxConsole.Checked != true)
                {
                    chromeDriverService.HideCommandPromptWindow = true;
                }

                driver = new ChromeDriver(chromeDriverService, chromeOptions);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                checkBoxBrowser.Enabled = false;
                checkBoxConsole.Enabled = false;

                item = infoBox.Tag.ToString();

                driver.Navigate().GoToUrl($"https://stalcraft-monitor.ru/auction?item={item}");

                var data = driver.FindElement(By.Id("nameCurrentItem"));
                infoBox.Text = data.GetAttribute("innerText");

                data = driver.FindElement(By.Id("iconItemData"));
                pictureBox.ImageLocation = data.GetAttribute("currentSrc");

                data = driver.FindElement(By.Id("tempMinPrice"));
                priceBox.Text = data.GetAttribute("innerText");

                while (priceBox.Text == "0 RUB")
                {
                    Thread.Sleep(100);
                    priceBox.Text = data.GetAttribute("innerText");
                }
            }
            else if (driver.WindowHandles.Count < flowLayoutPanel1.Controls.Count)
            {
                driver.SwitchTo().NewWindow(WindowType.Tab);

                item = infoBox.Tag.ToString();

                driver.Navigate().GoToUrl($"https://stalcraft-monitor.ru/auction?item={item}");

                var data = driver.FindElement(By.Id("nameCurrentItem"));
                infoBox.Text = data.GetAttribute("innerText");

                data = driver.FindElement(By.Id("iconItemData"));
                pictureBox.ImageLocation = data.GetAttribute("currentSrc");

                data = driver.FindElement(By.Id("tempMinPrice"));
                priceBox.Text = data.GetAttribute("innerText");

                while (priceBox.Text == "0 RUB")
                {
                    Thread.Sleep(100);
                    priceBox.Text = data.GetAttribute("innerText");
                }
            }
        }

        private void deleteButton1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                var i = flowLayoutPanel1.Controls.Count - 1;
                flowLayoutPanel1.Controls.RemoveAt(i);

                if (driver.WindowHandles.Count > 1)
                {
                    driver.SwitchTo().Window(driver.WindowHandles[i]);
                    driver.Close();
                }
                else
                {
                    driver.Quit();
                    driver = null;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Serialize();

            player.Play();
        }

        private void saveSessionButton_Click(object sender, EventArgs e)
        {
            SerializePanel();
        }

        private void loadSessionButton_Click(object sender, EventArgs e)
        {
            DeserializePanel();
        }

        #region Methods

        private string FixThatDamnPriceTag(string price)
        {
            string result = price.Split(',')[0]; // Removes ebanie kopeyki out
            result = result.Replace(" ", ""); // Removes whitespaces
            result = result.Replace(" ", ""); // Remove spaces
            return result;
        }

        private void Serialize()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
            };

            List<Item> items = new List<Item>();

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                Item item = new Item
                {
                    ItemName = listView1.Items[i].Text,
                    Id = listView1.Items[i].SubItems[1].Text
                };

                items.Add(item);
            }

            var fileName = "Settings/Items.json";
            var jsonString = JsonSerializer.Serialize(items, options);

            File.WriteAllText(fileName, jsonString);
        }

        private void Deserialize()
        {
            string fileName = "Settings/Items.json";
            if (File.Exists(fileName))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true,
                };

                string jsonString = File.ReadAllText(fileName);
                List<Item> item = JsonSerializer.Deserialize<List<Item>>(jsonString, options);

                listView1.Items.Clear();

                for (int i = 0; i < item.Count; i++)
                {
                    var listItem = listView1.Items.Add(item[i].ItemName);
                    listItem.SubItems.Add(item[i].Id);
                }
            }
        }

        private void SerializePanel()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true,
            };

            List<ItemPanel> items = new List<ItemPanel>();

            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                ItemPanel item = new ItemPanel
                {
                    ItemPanelId = flowLayoutPanel1.Controls[i].Controls[1].Tag.ToString(),
                    ItemPanelPrice = flowLayoutPanel1.Controls[i].Controls[3].Text,
                    ItemPanelTimer = flowLayoutPanel1.Controls[i].Controls[4].Tag.ToString()
                };

                items.Add(item);
            }

            var fileName = "Settings/Save.json";
            var jsonString = JsonSerializer.Serialize(items, options);

            File.WriteAllText(fileName, jsonString);
        }

        private void DeserializePanel()
        {
            var fileName = "Settings/Save.json";
            if (File.Exists(fileName))
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    WriteIndented = true,
                };

                string jsonString = File.ReadAllText(fileName);
                List<ItemPanel> items = JsonSerializer.Deserialize<List<ItemPanel>>(jsonString, options);

                flowLayoutPanel1.Controls.Clear();

                int addTimer = 0;

                for (int i = 0; i < items.Count; i++)
                {
                    //--------------------------------------------------[Main Panel]------------------------------------------------//
                    Panel panel = new Panel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.FromArgb(40, 40, 40),
                        Width = 211,
                        Height = 125
                    };
                    //---------------------------------------------------[Picture]--------------------------------------------------//
                    PictureBox pictureBox = new PictureBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.Gray,
                        Location = new Point(3, 3),
                        ImageLocation = "https://stalcraft-monitor.ru/db/icons/other/4k5gr.png",
                        Width = 64,
                        Height = 64
                    };
                    panel.Controls.Add(pictureBox);
                    //---------------------------------------------------[Info Box]-------------------------------------------------//
                    TextBox infoBox = new TextBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.Gray,
                        ForeColor = Color.White,
                        Location = new Point(73, 3),
                        Width = 133,
                        Height = 64,
                        Multiline = true,
                        TextAlign = HorizontalAlignment.Center,
                        Text = "Item Info",
                        Tag = items[i].ItemPanelId,
                        ReadOnly = true
                    };
                    panel.Controls.Add(infoBox);
                    //---------------------------------------------------[Price Box]------------------------------------------------//
                    TextBox priceBox = new TextBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.DimGray,
                        ForeColor = Color.White,
                        Location = new Point(3, 73),
                        Width = 133,
                        Height = 20,
                        TextAlign = HorizontalAlignment.Center,
                        Text = "10 000,00 ₽",
                        ReadOnly = true
                    };
                    panel.Controls.Add(priceBox);
                    //---------------------------------------------------[Price Threshold Box]--------------------------------------//
                    TextBox priceThresholdBox = new TextBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.DimGray,
                        ForeColor = Color.White,
                        Location = new Point(3, 99),
                        Width = 133,
                        Height = 20,
                        TextAlign = HorizontalAlignment.Center,
                        Text = items[i].ItemPanelPrice,
                    };
                    panel.Controls.Add(priceThresholdBox);
                    //---------------------------------------------------[Timer Box]------------------------------------------------//
                    TextBox timerBox = new TextBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.DimGray,
                        ForeColor = Color.White,
                        Location = new Point(142, 73),
                        Width = 64,
                        Height = 20,
                        TextAlign = HorizontalAlignment.Center,
                        Text = addTimer.ToString(),
                        Tag = items[i].ItemPanelTimer,
                        ReadOnly = true
                    };
                    panel.Controls.Add(timerBox);
                    //--------------------------------------------------------------------------------------------------------------//
                    flowLayoutPanel1.Controls.Add(panel);

                    addTimer += 10;

                    if (driver == null)
                    {
                        var chromeOptions = new ChromeOptions();
                        var chromeDriverService = ChromeDriverService.CreateDefaultService();

                        if (checkBoxBrowser.Checked != true)
                        {
                            chromeOptions.AddArgument("headless");
                        }

                        if (checkBoxConsole.Checked != true)
                        {
                            chromeDriverService.HideCommandPromptWindow = true;
                        }

                        driver = new ChromeDriver(chromeDriverService, chromeOptions);
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                        checkBoxBrowser.Enabled = false;
                        checkBoxConsole.Enabled = false;

                        item = infoBox.Tag.ToString();

                        driver.Navigate().GoToUrl($"https://stalcraft-monitor.ru/auction?item={item}");

                        var data = driver.FindElement(By.Id("nameCurrentItem"));
                        infoBox.Text = data.GetAttribute("innerText");

                        data = driver.FindElement(By.Id("iconItemData"));
                        pictureBox.ImageLocation = data.GetAttribute("currentSrc");

                        data = driver.FindElement(By.Id("tempMinPrice"));
                        priceBox.Text = data.GetAttribute("innerText");

                        while (priceBox.Text == "0 RUB")
                        {
                            Thread.Sleep(100);
                            priceBox.Text = data.GetAttribute("innerText");
                        }
                    }
                    else if (driver.WindowHandles.Count < flowLayoutPanel1.Controls.Count)
                    {
                        driver.SwitchTo().NewWindow(WindowType.Tab);

                        item = infoBox.Tag.ToString();

                        driver.Navigate().GoToUrl($"https://stalcraft-monitor.ru/auction?item={item}");

                        var data = driver.FindElement(By.Id("nameCurrentItem"));
                        infoBox.Text = data.GetAttribute("innerText");

                        data = driver.FindElement(By.Id("iconItemData"));
                        pictureBox.ImageLocation = data.GetAttribute("currentSrc");

                        data = driver.FindElement(By.Id("tempMinPrice"));
                        priceBox.Text = data.GetAttribute("innerText");

                        while (priceBox.Text == "0 RUB")
                        {
                            Thread.Sleep(100);
                            priceBox.Text = data.GetAttribute("innerText");
                        }
                    }
                }
            }
        }

        #endregion

        #region ItemRegion

        private void addItemButton_Click(object sender, EventArgs e)
        {
            var item = listView1.Items.Add(textNameBox.Text);
            item.SubItems.Add(textIdBox.Text);
            listView1.Items[listView1.Items.Count - 1].Selected = true;
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var i = listView1.SelectedIndices[0];
                var item = listView1.Items[i];
                item.Text = textNameBox.Text;
                item.SubItems[1].Text = textIdBox.Text;
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedIndices[0];
                listView1.Items.RemoveAt(item);
                if (item > 0)
                {
                    listView1.Items[item - 1].Selected = true;
                }
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            var i = listView1.SelectedIndices[0];
            var item = listView1.Items[i];

            textNameBox.Text = item.Text;
            textIdBox.Text = item.SubItems[1].Text;

            idSetBox1.Text = item.SubItems[1].Text;
        }

        #endregion

    }
}
