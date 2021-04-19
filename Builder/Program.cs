using System;

namespace Builder
{
    class Builder
    {
        private string js;
        public Builder()
        {
            this.js = "";
        }
        public Builder beginTag(string value)
        {
            this.js += "<" + value + ">";
            return this;
        }
        public Builder setContent(string value)
        {
            this.js += "document.write(" + value + ");";
            return this;
        }
        public Builder endTag(string value)
        {
            this.js += "</" + value + ">";
            return this;
        }
        public string get()
        {
            return this.js;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Builder js = new Builder();
            string code = js.beginTag("script")
                .setContent("5")
                .endTag("script").get();
            Console.WriteLine("\n" + code);
        }
    }
}
