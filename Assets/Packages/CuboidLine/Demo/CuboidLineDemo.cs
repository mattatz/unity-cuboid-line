using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CuboidLine
{

    public class CuboidLineDemo : MonoBehaviour {

        [SerializeField] protected Material lineMat;

        private void OnRenderObject()
        {
            GL.PushMatrix();
            GL.MultMatrix(transform.localToWorldMatrix);

            lineMat.SetPass(0);

            GL.Begin(GL.LINES);

            const int count = 10;
            const float pi2 = Mathf.PI * 2f;
            for(int i = 0; i < count; i++)
            {
                var t0 = (1f * i / count) * pi2;
                var t1 = (1f * (i + 1) / count) * pi2;
                var v0 = Vector3.right * Mathf.Cos(t0) + Vector3.up * Mathf.Sin(t0);
                var v1 = Vector3.right * Mathf.Cos(t1) + Vector3.up * Mathf.Sin(t1);
                GL.Vertex(v0); GL.Vertex(v1);
            }

            GL.End();
            GL.PopMatrix();
        }

    }

}


