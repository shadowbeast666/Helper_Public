using System.Collections.Concurrent;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;


namespace Project_Windows
{
    class Downloader
    {
        /*
        static void Main(string[] args)
        {

             static async Task Main(string[] args)
            {
                Uri site = new Uri("https://contoso.sharepoint.com/sites/siteA");
                string user = "joe.doe@contoso.onmicrosoft.com";
                SecureString password = GetSecureString($"Password for {user}");

                // Note: The PnP Sites Core AuthenticationManager class also supports this
                using (var authenticationManager = new AuthenticationManager())
                using (var context = authenticationManager.GetContext(site, user, password))
                {
                    context.Load(context.Web, p => p.Title);
                    await context.ExecuteQueryAsync();
                    Console.WriteLine($"Title: {context.Web.Title}");
                }
            }


            /*
            using (ClientContext ctx = new ClientContext("https://tenantname.sharepoint.com/sites/sitename/"))
            {
                string password = "********";
                string account = "username@tenantname.onmicrosoft.com";
                var secret = new SecureString();
                foreach (char c in password)
                {
                    secret.AppendChar(c);
                }

                ctx.Credentials = new AuthenticationManager();
                ctx.Load(ctx.Web);
                ctx.ExecuteQuery();

                List list = ctx.Web.Lists.GetByTitle("libraryTitle");

                FileCollection files = list.RootFolder.Folders.GetByUrl("/sites/sitename/shared documents/foldername").Files;

                ctx.Load(files);
                ctx.ExecuteQuery();

                foreach (Microsoft.SharePoint.Client.File file in files)
                {
                    FileInformation fileinfo = Microsoft.SharePoint.Client.File.OpenBinaryDirect(ctx, file.ServerRelativeUrl);

                    ctx.ExecuteQuery();

                    using (FileStream filestream = new FileStream("C:" + "\\" + file.Name, FileMode.Create))
                    {
                        fileinfo.Stream.CopyTo(filestream);
                    }

                }
            };
            */
        }
        

    }
            