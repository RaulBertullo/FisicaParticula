# Unity Particle Explosion

En este proyecto he hecho un sistema de partículas simple en Unity usando C#. La idea era generar una pequeña explosión de partículas sin usar el sistema de partículas que trae Unity por defecto.

Cuando se pulsa la tecla **E**, se instancian varias partículas en la posición del objeto. A cada una se le asigna una velocidad, ángulo y gravedad aleatorios para que el movimiento no sea siempre igual.

El script "Particle.cs" se encarga de calcular el movimiento de cada partícula en cada frame usando una velocidad inicial y gravedad, lo que hace que sigan una trayectoria parabólica. También controla el tiempo de vida y destruye la partícula cuando se supera.

El script "ParticlesController.cs" se encarga de crear las partículas y de asignarles los valores iniciales cuando se genera la explosión.

La idea del proyecto era practicar instanciación de objetos, movimiento con físicas básicas, uso de "Time.deltaTime" y control de múltiples objetos desde código.
