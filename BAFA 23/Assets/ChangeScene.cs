using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    public void Change_to_scene(int scene_to_change_to) {
        Application.LoadLevel(scene_to_change_to);
    }
}
