using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMesh : MonoBehaviour {

    public EdgeCollider2D edgeCollider;
    public float yDisplacement = 0.05f;
    public MeshFilter meshFilter;

    // Use this for initialization
    void Start() {
        for (int i = 1; i < edgeCollider.points.Length; i++)
        {
            var source2d = edgeCollider.points[i-1];
            var source = new Vector3(source2d.x, source2d.y, 0);
            var target2d = edgeCollider.points[i];
            var target = new Vector3(target2d.x, target2d.y, 0);
            var mesh = new Mesh();
            var vertices = new List<Vector3>();
            var triangles = new List<int>();

            vertices.Add(source);
            vertices.Add(target);
            vertices.Add(source + Vector3.down * yDisplacement);
            vertices.Add(target + Vector3.down * yDisplacement);

            triangles.AddRange(new int[] { 0, 1, 2 });
            triangles.AddRange(new int[] { 1, 3, 2 });


            mesh.vertices = vertices.ToArray();
            mesh.triangles = triangles.ToArray();
            meshFilter.mesh = mesh;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
