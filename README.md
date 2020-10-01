# Menza-scraper

Web Scraping tool created in C# using Windows Forms. It uses an exploit to scrape https://www.srce.unizg.hr/ and get receipt data for restaurant visits of any student as long as you have their JMBAG number. This was my final project for the "Object Oriented Programming 2" class and it scored an A.









As of since they have completely remade their backend system in an attempt to patch it. Their patch actually made it worse and now you can see all the personal information (literally all of it) of every student in Croatia.

If you are logged into the site and sent a GET HTTP request to https://issp.srce.hr/PretragaStudenta/Detalji?oib=0&jmbag=X

Where X = JMBAG of the student 

You can get literally all of their personal information. Hopefully they will fix this exploit. I did not update the code for the Menza Scraper to work again because I don't want people to abuse this for malicious purposes but I do believe this should be public so they are forced to finally fix it properly.
