import win32com.client
import datetime, locale
import pathlib

locale.setlocale(locale.LC_ALL, 'pl_PL')
data = datetime.datetime.now()
data_out = (data.strftime("%B"))
data_filename = (data.strftime("%d %B %Y"))

outlook = win32com.client.Dispatch('outlook.application')
mail = outlook.CreateItem(0)
mail.To =''
mail.Subject =''
mail.HTMLBody = '<h3>IMEI Sender</h3>'
mail.Body =''
mail.Attachments.Add(pathlib.Path(__file__).parent.resolve()+'\\'+str(data_filename)+".xlsx")
mail.Send()



