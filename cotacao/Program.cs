using System;
using HtmlAgilityPack;

namespace cotacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var html = @"https://br.investing.com/currencies/usd-brl";

                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load(html);

                var caminho = "/html/body/div[5]/section/div[4]/div[1]/div[1]/div[1]/div[1]/div[2]/span[1]";

                var node = htmlDoc.DocumentNode.SelectSingleNode(caminho);

                Console.WriteLine(node.InnerText);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
