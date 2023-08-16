using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class TestVRInput : InputTestFixture
{

    //Default test does have proper setup and teardown elements
    override
    public void Setup(){
        base.Setup();
    }

    [UnityTest]
    public IEnumerator TestVRInputWithEnumeratorPasses()
    {
        SceneManager.LoadScene("SampleScene");
        WaitForSceneLoad();

        yield return new WaitForSeconds(4);
        //Adding this to validate one assert. Not related to the Input Testing
        var canvas = GameObject.FindObjectOfType<Canvas>();
        Assert.NotNull(canvas);

    }

    private IEnumerator WaitForSceneLoad()
    {
        while (SceneManager.GetActiveScene().buildIndex > 0)
        {
            yield return null;
        }
    }
}
