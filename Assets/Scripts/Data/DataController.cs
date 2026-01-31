using System.IO;
using UnityEngine;

public class DataController : MonoBehaviour
{
    //Los struct son parecida a las clases, ya que pueden tener variables y métodos.
    //Pero se diferencian en como se emite la información.
    //Una struct es una estructura de datos.
    //Cuando queremos guardar la DATA de nivel, experiencia, fuerza y vida del player es un struct
    [System.Serializable]
    public struct DataBucket
    {
        public int explosionCount;
        public int spawnCount;
        public int collisionCount;

        //Podemos tener metodos dentro del struct
        public void Save(string path)
        {
                                            //this -> se refiere al DataBucket
                                            //Si se pusiera en el void Start, se referiría a todo el archivo
            string jsonString = JsonUtility.ToJson(this);
            File.WriteAllText(path, jsonString);
        }
    }

    public DataBucket bucket;
    
    void Start()
    {
        bucket.explosionCount=0;
        bucket.spawnCount=0;
        bucket.collisionCount=0;
    }

    //Cuando el jugador se salga del juego se guardará
    private void OnDestroy()
    {
        //Indicamos la ruta donde queremos guardar el juego
        bucket.Save(Application.dataPath + "/Data/data.txt");
    }

    public void SendData (KPIType dataType)
    {
        //Permite evaluar los casos
        switch (dataType)
        {
            case KPIType.CollisionKPI:
            bucket.collisionCount++;
            break;
            case KPIType.ExplosionsKPI:
            bucket.explosionCount++;
            break;
            case KPIType.SpawnedBallKPI:
            bucket.spawnCount++;
            break;
        }
    }
}
