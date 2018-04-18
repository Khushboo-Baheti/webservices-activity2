using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace AC_06
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void userview_Click(object sender, EventArgs e)
        {
            HttpWebRequest servicerequest = (HttpWebRequest)WebRequest.Create("http://localhost:28520/api/Book");
            servicerequest.Method = "GET";
            servicerequest.Accept = "text/xml";
            HttpWebResponse serviceresponse = (HttpWebResponse)servicerequest.GetResponse();
            XmlDocument xmlDoc = new XmlDocument();
            using (HttpWebResponse resp = servicerequest.GetResponse() as HttpWebResponse)
            {
                xmlDoc.Load(resp.GetResponseStream());
            }

            Label1.Text = "Book Name: " + xmlDoc.GetElementsByTagName("Book")[0].InnerText;

            for (int i = 1; i < xmlDoc.GetElementsByTagName("Book").Count - 1; i++)
            {
                var curResult = (XmlElement)xmlDoc.GetElementsByTagName("Book")[i];
              Label1.Text = Label1.Text + "<br/>" + i.ToString() + ".&nbspBook Name: " + curResult.GetElementsByTagName("BookName")[0].InnerText;
              Label1.Text = Label1.Text + "<br/>" + ".&nbsppAuthor: " + curResult.GetElementsByTagName("Author")[0].InnerText;
              Label1.Text = Label1.Text + "<br/>" + ".&nbspCategory: " + curResult.GetElementsByTagName("Category")[0].InnerText;
              Label1.Text = Label1.Text + "<br/>" + ".&nbspSatus: " + curResult.GetElementsByTagName("Status")[0].InnerText;
         }
        }

        protected void viewbyid_Click(object sender, EventArgs e)
        {
            HttpWebRequest servicerequest = (HttpWebRequest)WebRequest.Create("http://localhost:28520/api/Book/"+bid.Text);
            servicerequest.Method = "GET";
            servicerequest.Accept = "text/xml";
            HttpWebResponse serviceresponse = (HttpWebResponse)servicerequest.GetResponse();
            XmlDocument xmlDoc = new XmlDocument();
            using (HttpWebResponse resp = servicerequest.GetResponse() as HttpWebResponse)
            {
                xmlDoc.Load(resp.GetResponseStream());
            }
                Label1.Text =  ".&nbspBook Name: " + xmlDoc.GetElementsByTagName("BookName")[0].InnerText;
                Label1.Text = Label1.Text + "<br/>" + ".&nbsppAuthor: " + xmlDoc.GetElementsByTagName("Author")[0].InnerText;
                Label1.Text = Label1.Text + "<br/>" + ".&nbspCategory: " + xmlDoc.GetElementsByTagName("Category")[0].InnerText;
                Label1.Text = Label1.Text + "<br/>" + ".&nbspSatus: " + xmlDoc.GetElementsByTagName("Status")[0].InnerText;
        }

        protected void getbycat_Click(object sender, EventArgs e)
        {
            HttpWebRequest servicerequest = (HttpWebRequest)WebRequest.Create("http://localhost:28520/api/Book?category="+cat.Text);
            servicerequest.Method = "GET";
            servicerequest.Accept = "text/xml";
            HttpWebResponse serviceresponse = (HttpWebResponse)servicerequest.GetResponse();
            XmlDocument xmlDoc = new XmlDocument();
            using (HttpWebResponse resp = servicerequest.GetResponse() as HttpWebResponse)
            {
                xmlDoc.Load(resp.GetResponseStream());
            }

            Label1.Text = "Book Name: " + xmlDoc.GetElementsByTagName("Book")[0].InnerText;

            for (int i = 1; i < xmlDoc.GetElementsByTagName("Book").Count - 1; i++)
            {
                var curResult = (XmlElement)xmlDoc.GetElementsByTagName("Book")[i];
                Label1.Text = Label1.Text + "<br/>" + i.ToString() + ".&nbspBook Name: " + curResult.GetElementsByTagName("BookName")[0].InnerText + "&nbsp&nbsp";
                Label1.Text = Label1.Text + "<br/>" + ".&nbsppAuthor: " + curResult.GetElementsByTagName("Author")[0].InnerText + "&nbsp&nbsp";
                Label1.Text = Label1.Text + "<br/>" + ".&nbspCategory: " + curResult.GetElementsByTagName("Category")[0].InnerText + "&nbsp&nbsp";
                Label1.Text = Label1.Text + "<br/>" + ".&nbspSatus: " + curResult.GetElementsByTagName("Status")[0].InnerText + "&nbsp&nbsp";
            }
        }
    }
    }