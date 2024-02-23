using UnityEngine;

public class RespawnObstricles : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform geratepoint;

    // Start is called before the first frame update

    private void Genrate()
    {
        //Spwan Prefabs Randomly
        int range = Random.Range(0, prefabs.Length);// 0 is include

        Instantiate(prefabs[range], geratepoint.position, Quaternion.identity);
        //Debug.Log(prefabs[range].name + " range: " + range);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //float range = Random.Range(0f, 5f);
        //Invoke("Genrate", range);
        Genrate();
    }
}