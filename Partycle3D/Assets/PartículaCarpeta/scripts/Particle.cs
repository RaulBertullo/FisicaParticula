using UnityEngine;

public class Particle : MonoBehaviour
{
    public float velocidadInicial;
    public float anguloIncial;
    public float anguloInicialZ;
    public float tiempoVida;
    public float tiempoActivo;
    public float gravedad;
    
    public GameObject sprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoActivo += Time.deltaTime;
        float AnguloRadianes = Mathf.Rad2Deg * anguloIncial;
        float AnguloRadianesZ = Mathf.Rad2Deg * anguloInicialZ;
        float x = velocidadInicial * Mathf.Cos(AnguloRadianes) * tiempoActivo;
        float y = velocidadInicial * Mathf.Sin(AnguloRadianes) * tiempoActivo - 0.5f * gravedad * tiempoActivo * tiempoActivo;
        float z = velocidadInicial * Mathf.Cos(AnguloRadianesZ) * tiempoActivo;

        transform.position = new Vector3(x, y, z);
        
        if (tiempoActivo > tiempoVida)
        {
            Destroy(gameObject);
        }
    }
}
