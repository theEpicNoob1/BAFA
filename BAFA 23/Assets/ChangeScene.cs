using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public void Change_to_scene(int scene_to_change_to) {
        SceneManager.LoadScene(scene_to_change_to);
    }
}
