public class CuentaDeCheques : CuentaBancaria {
public double Sobregiro {get; private set;}
public CuentaDeCheques(double saldo, double sobregiro) : base(saldo) => Sobregiro = sobregiro;
public override bool Retira(double cantidad) {
double requerida = cantidad - Saldo;
if(Saldo>=cantidad){
    Saldo-=cantidad;
    return true;
}else if(Sobregiro<requerida) 
    return false;
 else {
    Sobregiro-=requerida;
    Saldo=0.0f;
        }
    return false;
    }
}