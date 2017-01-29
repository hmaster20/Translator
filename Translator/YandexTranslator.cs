using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Translator
{
    class YandexTranslator
    {
        public string Translate(string s, string lang)
        {
            if (s.Length > 0)
            {
                WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                    + "key=trnsl.1.1.20170127T184343Z.c57386f5c18826ab.c3942baf91d3a5c948253592772906880173fc24"
                    + "&text=" + s
                    + "&lang=" + lang);

                try
                {
                    WebResponse response = request.GetResponse();
                    using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                    {
                        string line;
                        if ((line = stream.ReadLine()) != null)
                        {
                            TranslationLang translation = JsonConvert.DeserializeObject<TranslationLang>(line);
                            s = "";

                            foreach (string str in translation.text)
                                s += str;
                        }
                    }
                }
                catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
                return s;
            }
            else
                return "";
        }

        public Dictionary<string, string> nnn = new Dictionary<string, string>();

        public List<string> GetAlldirection()
        // public Dictionary<string, string> GetAlldirection()
        {
            WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/getLangs?"
                + "key=trnsl.1.1.20170127T184343Z.c57386f5c18826ab.c3942baf91d3a5c948253592772906880173fc24"
                + "&ui=" + "ru");

            List<string> spisok = new List<string>();

            try
            {
                WebResponse response = request.GetResponse();
                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;
                    if ((line = stream.ReadLine()) != null)
                    {
                        TranslationCode translation = JsonConvert.DeserializeObject<TranslationCode>(line);

                        List<string> st = new List<string>(translation.dirs);
                        Dictionary<string, string> dd = new Dictionary<string, string>(translation.langs);

                        foreach (var item in st)
                        {
                            string[] arr = item.Split('-');
                            string s1 = dd[arr[0]];
                            string s2 = dd[arr[1]];

                            spisok.Add(s1 + "-" + s2);

                            nnn.Add(item, (s1 + "-" + s2));
                        }
                    }
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }

            return spisok;
        }
    }

    class TranslationLang
    {
        public string code { get; set; }
        public string lang { get; set; }
        public string[] text { get; set; }
    }

    class TranslationCode
    {
        public string[] dirs { get; set; }
        public Dictionary<string, string> langs { get; set; }
    }

    class Translation
    {
        public Translation()
        {
            lng = new Dictionary<string, string>();
        }

        public Dictionary<string, string> lng { get; set; }

        public override string ToString()
        {
            return lng.Values.ToString();
        }
    }
}