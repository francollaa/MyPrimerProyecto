
using UnityEngine;

public class Test : MonoBehaviour
{
    //public float playerSpeed = 0.2f;
    public Vector3 escala;
    //public int money = 0;
    public float VidaJugador = 100;
    
    void Start()
    {
        //SumarDosNumeros();
        ///int numeritoA = 30;
        //SumarCinco(ref numeritoA);
        
        //Debug.Log(numeritoA);
    }

    
    void Update()
    {
        QuitarVidaJugador();
        MovimientoJugador();
        
        //JuntarDinero();
        //transform.position += new Vector3(0.1f * playerSpeed, 0.1f, 0.1f);
        //transform.localScale += escala;
        //Debug.DrawRay(transform.position,new Vector3(1,0,0)*5,Color.red); (sale un rayo laser del objeto)
    }
    void MovimientoJugador()
    {
        transform.position += new Vector3(0.0001f, 0.0001f, 0.0001f);
        
    }

    
    void QuitarVidaJugador()
    {
        VidaJugador -= Time.deltaTime;
        Debug.Log(VidaJugador + " Sos latinoamericano");
    }
    //void JuntarDinero()
    //{
        //money = money + 1;
        //Debug.Log(money);
    //}
    //void SumarDosNumeros(int n1, int n2)
    //{
        //Debug.Log(n1+n2);
    //}
    //public void SumarCinco(ref int numero)
    //{
        //numero = numero + 5;
    //}
}
