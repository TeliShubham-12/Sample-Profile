namespace TFL;
using System;
using System.Collections;
public class Shipper: ICloneable {

        public int id;
        public string name;
        public Shipper(){
            this.id=12;
            this.name="Surya Couriers";

        }
        public Shipper(int id,String name){
            this.id=id;
            this.name =name;

        }
        public object Clone() {
            Shipper temp=new Shipper();
            temp.id=this.id;
            temp.name=this.name;
            return temp;


        }
        public override string ToString(){
            return "Id="+id+ " "+"Name="+name;
        }
    }
    
