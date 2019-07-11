using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureCapture
{
    public partial class Form1 : Form
    {
        public List<string> ImgList = new List<string>();

        public int _loadFile = 0;

        public string title = string.Empty;

        public int _totalFile = 0;

        public string[] exts = { ".bmp", ".dib", ".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif", ".tif", ".tiff" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxEdit1.Items.Add("UTF-8");
            this.comboBoxEdit1.Items.Add("GB2312");
        }

        private void BtnPictureNum_Click(object sender, EventArgs e)
        {
            try
            {
                ImgList.Clear();
                HtmlWeb htmlWeb = new HtmlWeb();
                if (string.IsNullOrWhiteSpace(comboBoxEdit1.Text))
                {
                    MessageBox.Show("请选择编码格式");
                    return;
                }
                htmlWeb.OverrideEncoding = Encoding.GetEncoding(comboBoxEdit1.Text.ToString());
                int pageMinIndex = Convert.ToInt32(txtStartPage.Text);
                int pageMaxIndex = Convert.ToInt32(txtEndPage.Text);
                this.textBox1.AppendText("抓取到的图片地址");
                for (int i = pageMinIndex; i <= pageMaxIndex; i++)
                {
                    string url = txtWebText.Text.Trim().ToString();
                    if (i >= 2)
                    {
                        url = url.Substring(0, url.LastIndexOf(".")).ToString() + "_" + i + ".html";
                    }
                    HtmlAgilityPack.HtmlDocument htmlDocument = htmlWeb.Load(url);
                    if (htmlDocument.DocumentNode.InnerText.Contains("未找到"))
                    {
                        textBox1.AppendText("未找到图片");
                        return;
                    }
                    HtmlNodeCollection nodes = null;
                    if (url.Contains("https://www.mntup.com"))
                    {
                        title = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='title']").InnerText;
                        nodes = htmlDocument.DocumentNode.SelectNodes("//img");
                    }
                    else if (url.StartsWith("http://www.mmonly.cc", StringComparison.OrdinalIgnoreCase))
                    {
                        title = htmlDocument.DocumentNode.SelectSingleNode("//h1").InnerText.Substring(0, htmlDocument.DocumentNode.SelectSingleNode("//h1").InnerText.Length - 5);
                        nodes = htmlDocument.DocumentNode.SelectNodes("//div[@id='big-pic']//img");
                    }
                    else
                    {
                        title = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='title']")?.InnerText;
                        nodes = htmlDocument.DocumentNode.SelectNodes("//img");
                    }
                    bool flag2 = nodes == null || nodes.Count <= 0;
                    if (flag2)
                    {
                        MessageBox.Show($@"当前页{i}未找到图片,或没有第{i}页");
                        ImgList.Clear();
                        textBox1.Clear();
                        return;
                    }
                    int index = this.txtWebText.Text.Trim().IndexOf(".com");
                    string urls = this.txtWebText.Text.Trim().ToString().Substring(0, 21);
                    foreach (HtmlNode item in nodes)
                    {
                        //https://www.mntup.com/YouMi/zhangyumeng_38bebee5.html
                        string houzui = item.Attributes["src"]?.Value;
                        if (string.IsNullOrEmpty(houzui)) continue;
                        houzui = houzui.Substring(houzui.LastIndexOf("."), 4);
                        if (houzui != ".jpg")
                        {
                            continue;
                        };
                        string imgurl = "";
                        if (!item.Attributes["src"].Value.StartsWith("http") &&
                        !item.Attributes["src"].Value.StartsWith("https"))
                        {
                            imgurl = urls + item.Attributes["src"].Value;
                        }
                        else
                        {
                            imgurl = item.Attributes["src"].Value;
                        }
                        this.textBox1.AppendText(imgurl + "\r\n");
                        this.ImgList.Add(imgurl);
                    }
                }
                this._totalFile = ImgList.Count;
                this.textBox1.AppendText("总共获取图片" + ImgList.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void TxtStartPage_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtStartPage.Text) <= 0)
            {
                MessageBox.Show("请输入大于0的整数");
            }
        }

        private void TxtEndPage_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtEndPage.Text) <= 0)
            {
                MessageBox.Show("请输入大于0的整数");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.textBox1.Clear();
                if (ImgList.Count <= 0) return;
                //重置加载文件数
                _loadFile = 0;
                int index = 1;
                Task.Factory.StartNew(() =>
                {
                    foreach (var item in ImgList)
                    {
                        WebClient webClient = new WebClient();
                        //webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);
                        //webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);
                        webClient.Proxy = null;
                        Uri uri = new Uri(item);

                        if (!Directory.Exists(System.Environment.CurrentDirectory + "\\Img"))
                        {
                            Directory.CreateDirectory(System.Environment.CurrentDirectory + "\\Img");

                        }
                        var imghouzhui = item.Substring(item.LastIndexOf(".")).Substring(0, 4);



                        string fileName = title == "" ? Guid.NewGuid().ToString() : title + "_" + index + imghouzhui;
                        webClient.DownloadFileAsync(uri, System.Environment.CurrentDirectory + "\\Img\\" + fileName);
                        index++;
                        //textBox1.Text = "下载完成";
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
    }
}
