using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Track : MonoBehaviour {

    public int day;
    public Scene currentRoom;
    public string currentRoomName;
    public bool sleep;

    private void Awake()
    {
        sleep = true;
        day = 0;
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += CheckScene;
    }

    void CheckScene(Scene scene, LoadSceneMode mode)
    {
        Debug.Log(scene.name);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        if (currentRoomName == "LivingRoom" && scene.name == "Hallway")
        {
            camera.transform.position = new Vector3(27f, 0, -10);
            player.transform.position = new Vector2(43.05f, 0);
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (currentRoomName == "Scene1" && scene.name == "Kitchen")
        {
            camera.transform.position = new Vector3(-4, 0, -10);
            player.transform.position = new Vector2(-18.25f, 0);
        }
        else if (currentRoomName == "Hallway" && scene.name == "Kitchen")
        {
            camera.transform.position = new Vector3(4, 0, -10);
            player.transform.position = new Vector2(18.25f, 0);
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (currentRoomName == "Kitchen" && scene.name == "Hallway")
        {
            camera.transform.position = new Vector3(-28.8f ,0, -10);
            player.transform.position = new Vector2(-43.05f, 0);
        }
        else if ( currentRoomName == "Bathroom" && scene.name == "Hallway")
        {
            camera.transform.position = new Vector3( 0, 0, -10);
            player.transform.position = new Vector2(0, 0);
        }
        currentRoom = scene;
        currentRoomName = scene.name;
    }
}
