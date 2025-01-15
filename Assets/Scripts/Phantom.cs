using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phantom : MonoBehaviour
{
    public float speed;

    public PhantomNode target;

    public GameObject tracks;
    public List<GameObject> trackTracker;

    float cd;
    float nextcd = 2;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.transform.position) <= 0.1f)
        {
            target.NextNode(this);
        }

        cd = Time.time;

        if (cd >= nextcd)
        {
            trackTracker.Add(Instantiate(tracks, transform.position, transform.rotation));
            nextcd = Time.time + 2;
        }
    }

    public void ResetPhantom(PhantomNode newNode)
    {
        target = newNode;
        foreach (var item in trackTracker)
        {
            Destroy(item);
        }
        trackTracker.Clear();
        transform.position = newNode.transform.position;
    }
}
