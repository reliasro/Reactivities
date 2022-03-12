import { strictEqual } from "assert";
import { StringLiteralLike } from "typescript";

interface Duck {
    precio: number,
    costo: number,
    nombre: string
    fechaCompra: Date
}

const duck ={name:"dsfsdf",
 color: "red", 
 size:23,
 imprimir:(doc:any)=>{}
};

 class Empleado{
    
   nombre:string; 
   fecha:string;
   sueldo:number;
   
   constructor(){
       this.nombre="srtrer";
       this.fecha="" ;
       this.sueldo=0;
   }

    salvar(){

    }

    imprimir(){

    }

}

const sumar=(e:Empleado)=>{

};


console.log( duck.color);


