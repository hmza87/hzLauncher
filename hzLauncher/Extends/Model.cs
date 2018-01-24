using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Diagnostics;

namespace hzLauncher.Extends
{
    public class Model
    {
        private static string data_file = "data.json";
        private List<ShortCut> shorts;
        public Model()
        {
            this.load();
            if (this.shorts == null) this.shorts = new List<ShortCut>();
        }


        public List<ShortCut> shurtcuts()
        {
            return shorts;
        }

        public Model insert(string name, string uri, string folder)
        {

            ShortCut s = new ShortCut(name, uri, folder, DateTime.Now, DateTime.Now);
            this.shorts.Add(s);
            return this;
        }

        public Model commit()
        {
            string json = JsonConvert.SerializeObject(shorts);
            System.IO.File.WriteAllText(data_file, json);
            return this.load();
        }

        public Model load()
        {
            if (!System.IO.File.Exists(data_file)) System.IO.File.WriteAllText(data_file, "");

            try
            {
                this.shorts = JsonConvert.DeserializeObject<List<ShortCut>>(System.IO.File.ReadAllText(data_file));
            }
            catch (Exception e)
            {

                throw;
            }
            return this;
        }
    }

    public class ShortCut
    {
        public string name;
        public string uri;
        public string folder;
        public DateTime last_used;
        public DateTime time_added;


        public ShortCut(string name_, string uri_, string folder_, DateTime lu, DateTime ta)
        {
            this.name = name_;
            this.uri = uri_;
            this.folder = folder_;
            this.last_used = lu;
            this.time_added = ta;
        }

        public bool Run()
        {
            try
            {
                Process.Start(this.uri);
                this.last_used = DateTime.Now;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }


}
