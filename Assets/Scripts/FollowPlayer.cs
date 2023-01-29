using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    void Update () {
        transform.position = player.transform.position + new Vector3(1.1f, 3f, 4.58f);
    }
}