using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChanger : MonoBehaviour {
    public List<GameObject> list;
    private int currentCamera;

    private void Start() {
        for(int i = 0; i < list.Count; i++) {
            list[i].SetActive(false);
        }

        list[0].SetActive(true);
        currentCamera = 0;
    }

    public void NextCamera() {
        list[currentCamera].SetActive(false);
        currentCamera++;
        if(currentCamera > list.Count - 1) {
            currentCamera = 0;
        }

        list[currentCamera].SetActive(true);
    }

    public void LastCamera() {
        list[currentCamera].SetActive(false);
        currentCamera --;
        if(currentCamera < 0) {
            currentCamera = list.Count - 1;
        }
        list[currentCamera].SetActive(true);
    }
}
