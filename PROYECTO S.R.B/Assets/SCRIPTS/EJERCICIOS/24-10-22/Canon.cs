using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public Transform shootPoint;

    public GameObject canonBallPrefab;

    public float shootForce;

    public float timeToShoot;

    private float timeSinceLastShoot;

    public void Shoot()
    {
        GameObject canonBall = Instantiate(canonBallPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody canonBallRigibody = canonBall.GetComponent<Rigidbody>();
        canonBallRigibody.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;
        if (timeSinceLastShoot > timeToShoot)
        {
            Shoot();
            timeSinceLastShoot = 0;
        }
    }
}