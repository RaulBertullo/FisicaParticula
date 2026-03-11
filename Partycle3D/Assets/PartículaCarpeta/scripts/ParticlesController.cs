using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class ParticlesController : MonoBehaviour
{
    public GameObject Particle;
    List<int> gameObjects = new List<int>();
    public int num_particles;
    public float initial_velocity;
    public float initial_angle;
    public float initial_anglez;
    public float lifeTime;
    public float gravity;
    private float tiempoSpawn;
    public float tiempoIntervalo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempoSpawn += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E))
        {
            CreateParticleExplotion();
            tiempoSpawn = 0;
        }
    }

    private void CreateParticleExplotion()
    {
        for(int i = 0; i < num_particles; i++)
        {
            GameObject parti = Instantiate(Particle, transform.position, Quaternion.identity);
            Particle Script = parti.GetComponent<Particle>();

            Script.velocidadInicial = initial_velocity * Random.Range(1, 3);
            Script.anguloIncial = initial_angle * Random.Range(1, 360);
            Script.anguloInicialZ = initial_anglez * Random.Range(1, 360);
            Script.tiempoVida = lifeTime;
            Script.gravedad = gravity * Random.Range(1, 3);
        }
        
    }
}
