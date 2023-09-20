public class CuentaBancaria {
public double Saldo {get; protected set;} //protected para que pueda accederse desde la clase derivada
public CuentaBancaria(double cantidad) => Saldo = cantidad;
public void Deposita(double cantidad) => Saldo += cantidad;
public virtual bool Retira(double cantidad) {
        if(Saldo >= cantidad) {
        Saldo -= cantidad;
        return true;
        } else return false;
    }
}