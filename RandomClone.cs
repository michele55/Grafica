using UnityEngine;
public class RandomClone: MonoBehaviour
{

public int numOfClone; 
public GameObject [] clones;
public GameObject block;
//public int y=1;



void Start()
{
  
//clones = new GameObject[numOfClone];
for (int x = 0; x < numOfClone; ++x)
{
    clones[x]=block;
    Vector3 randomSpawnPosition=new Vector3(Random.Range(0,1),1,Random.Range(0,1));
Instantiate(block, randomSpawnPosition, Quaternion.identity);

//Instantiate(block, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), Quaternion.identity);
//Instantiate(block, new Vector3(transform.position.x + 1+x, transform.position.y + y, transform.position.z),
//Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y*y*10, transform.rotation.z));

}

}


void Update(){
    //Color color=GetComponent<Renderer> ().material.color=Color.yellow;
    var cubeRenderer=block.GetComponent<Renderer>();
    cubeRenderer.material.SetColor("_Color",Color.yellow);
    

}
}
