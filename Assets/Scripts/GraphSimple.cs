using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphSimple : MonoBehaviour
{

    public TextAsset file;
    public GameObject nodepf;
    public GameObject edgepf;
    public float width;
    public float length;
    public float height;

    void Start()
    {
        // instantiate A, B, C, D, E
        GameObject A = Instantiate(nodepf, new Vector3(Random.Range(-width / 2, width / 2), Random.Range(-length / 2, length / 2), Random.Range(-height / 2, height / 2)), Quaternion.identity);
        GameObject B = Instantiate(nodepf, new Vector3(Random.Range(-width / 2, width / 2), Random.Range(-length / 2, length / 2), Random.Range(-height / 2, height / 2)), Quaternion.identity);
        GameObject C = Instantiate(nodepf, new Vector3(Random.Range(-width / 2, width / 2), Random.Range(-length / 2, length / 2), Random.Range(-height / 2, height / 2)), Quaternion.identity);
        GameObject D = Instantiate(nodepf, new Vector3(Random.Range(-width / 2, width / 2), Random.Range(-length / 2, length / 2), Random.Range(-height / 2, height / 2)), Quaternion.identity);
        GameObject E = Instantiate(nodepf, new Vector3(Random.Range(-width / 2, width / 2), Random.Range(-length / 2, length / 2), Random.Range(-height / 2, height / 2)), Quaternion.identity);
        // make nodes children of graph object
        A.transform.parent = transform;
        B.transform.parent = transform;
        C.transform.parent = transform;
        D.transform.parent = transform;
        E.transform.parent = transform;
        // change name
        A.name = "node A";
        B.name = "node B";
        C.name = "node C";
        D.name = "node D";
        E.name = "node E";

        // get script instances
        Node AS = A.GetComponent<Node>();
        Node BS = B.GetComponent<Node>();
        Node CS = C.GetComponent<Node>();
        Node DS = D.GetComponent<Node>();
        Node ES = E.GetComponent<Node>();
        // add edges      
        AS.SetEdgePrefab(edgepf); AS.AddEdge(BS);
        AS.AddEdge(CS);
        BS.SetEdgePrefab(edgepf); BS.AddEdge(DS);
        CS.SetEdgePrefab(edgepf); CS.AddEdge(DS);
        DS.SetEdgePrefab(edgepf); DS.AddEdge(ES);
        DS.AddEdge(AS);


        void Update() { }
    }
}