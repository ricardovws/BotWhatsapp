using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace BotWhatsapp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string url = "http://web.whatsapp.com";

            //string url = "https://www.google.com/";

            List<string> contacts = new List<string>()
            {
                //"Paulinha ❤"
                "Nothing"
               
            };

            ChromeDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            //Thread.Sleep(5000);

            //Actions action = new Actions(driver);
            //action.SendKeys("amzn stocks").Perform();

            //Thread.Sleep(5000);

            //action.SendKeys(Keys.Enter).Perform();

            //action.SendKeys(Keys.Home).Perform();
         
            Thread.Sleep(10000);

           

            //AutoItX autoIt = new AutoItX();

            //string strCmdText;
            //strCmdText = "/C notepad.exe";
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //AutoItX.Run("notepad.exe");
            //AutoItX.Run("CMD.exe", strCmdText);
            //AutoItX.WinWaitActive("Untitled");
            //AutoItX.Send("I'm in notepad");
            //IntPtr winHandle = AutoItX.WinGetHandle("Untitled");
            //AutoItX.WinKill(winHandle);



            SendTextMessages(contacts, driver);

        }
               
        static void SendTextMessages(List<string> contacts, ChromeDriver driver)
        {
            foreach (var contact in contacts)
            {
                //Depois de abrir o whats, ele digita o nome do contato no campo de busca

                //<div class="_3FRCZ copyable-text selectable-text" contenteditable="true" data-tab="3" dir="ltr"></div>
                var searchElement = driver.FindElementByClassName("_3FRCZ");
                searchElement.SendKeys(contact);

                //Pressiona enter e abre a conversa com o contato
                searchElement.SendKeys(Keys.Enter);

                //Digita alguma abobrinha:

                var chatElement = driver.FindElementByClassName("_3uMse");
                chatElement.SendKeys("Olá, você acaba de receber uma mensagem de um robô-teste do whatsapp. Não tenha medo.");

                Thread.Sleep(5000);

                //Depois de digitar, pressiona enter para enviar mensagem
                chatElement.SendKeys(Keys.Enter);
                Thread.Sleep(2000);
                chatElement.SendKeys(Keys.Enter);

                //chatElement.SendKeys(Keys.Enter);

                //Thread.Sleep(5000);
                //Agora precisa abrir a opção de anexos
                var menus = driver.FindElementsByClassName("_8EvFT");
                menus[4].Click();

                Thread.Sleep(5000);
                //Agora precisa clicar na primeira opção, que é de anexar imagens.
                //var attachments = driver.FindElementsByClassName("PVMjB");
                //attachments[0].Click();

                //Thread.Sleep(5000);

                //Lidando com a página de upload de imagem, que está fora do domínio do browser

                //InputSimulator s = new InputSimulator();
                //s.Keyboard.TextEntry(@"C:\teste.jpg");
                //s.Keyboard.KeyPress(VirtualKeyCode.TAB);
                //s.Keyboard.KeyPress(VirtualKeyCode.TAB);
                //s.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                //Thread.Sleep(5000);

                //Agora precisa confirmar o envio da imagem
                //s.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                
                //AutoItX3 autoIt = new AutoItX3();
                //autoIt.WinActivate("Abrir");
                //autoIt.Send(@"C:\testes\teste.jpg");
                //Thread.Sleep(2000);
                //autoIt.Send("{ENTER}");

                //Actions action = new Actions(driver);

                //action.SendKeys("teste").Perform();



                //Agora cola o endereço da imagem:
                //var imagePath = @"C:\LIXO\ganjah.jpg";
                //Thread.Sleep(10000);
                //action.SendKeys(imagePath).Perform();

                //Thread.Sleep(3000);

                //dá 2 tabs para ir até o "abrir"

                //action.SendKeys(Keys.Tab).Perform();
                //Thread.Sleep(2000);
                //action.SendKeys(Keys.Tab).Perform();

                //E dá um enter para fazer o upload

                //action.SendKeys(Keys.Enter).Perform();





                //action.SendKeys(Keys.Enter).Perform();



                ////<span dir="auto" title="Nothing" class="_3ko75 _5h6Y_ _3Whw5"><span class="matched-text _3Whw5">Nothin</span>g</span>
                ///

                //_3ko75 _5h6Y_ _3Whw5
                //var contactElement = driver.FindElementByXPath($"//span[@title='{contact}']");
                //var contactElement = driver.FindElementByClassName("_3ko75 _5h6Y_ _3Whw5");

                //contactElement.Click();

                ////<div tabindex="-1" class="_2FVVk _2UL8j"><div class="_2FbwG" style="visibility: visible;">Type a message</div><div class="_3FRCZ copyable-text selectable-text" contenteditable="true" data-tab="1" dir="ltr" spellcheck="true"></div></div>
                //Thread.Sleep(10000);

                //var chatElement = driver.FindElementByClassName("_3uMse");
                //chatElement.SendKeys("Olá, você acaba de receber uma mensagem de um robô-teste do whatsapp. Não tenha medo.");

                //Thread.Sleep(2000);

                ////< span data - testid = "send" data - icon = "send" class=""><svg xmlns = "http://www.w3.org/2000/svg" viewBox="0 0 24 24" width="24" height="24"><path fill = "currentColor" d="M1.101 21.757L23.8 12.028 1.101 2.3l.011 7.912 13.623 1.816-13.623 1.817-.011 7.912z"></path></svg></span>

                //var buttonSendElement = driver.FindElementByXPath($"//span[@data-icon= 'send']");

                //Thread.Sleep(5000);

                //buttonSendElement.Click();
            }

        }
    }
}
