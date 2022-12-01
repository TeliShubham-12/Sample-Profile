using TFL;
Shipper shp1=new Shipper(23, "Fedex");
Shipper shp2=new Shipper(12,"UPS");
Shipper shp3=new Shipper(34, "DHL");


Shipper shp4=(Shipper)shp1.Clone();//deeep copy


Console.WriteLine(shp1);
Console.WriteLine(shp4);
shp1.name="Palande couriers";
Console.WriteLine(shp1);
Console.WriteLine(shp4);

