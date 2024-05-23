using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCAuctionFetcher
{
    public class Item
    {
        public string ItemName { get; set; }
        public string Id { get; set; }
    }

    public class ItemPanel
    {
        public string ItemPanelId { get; set; }
        public string ItemPanelTimer { get; set; }
        public string ItemPanelPrice { get; set; }
    }
}
