# How to use Unity with Git

_Steps 1 - 3 are necessary if you don't have Homebrew and/or git-lfs installed._

1. Install [Homebrew](https://brew.sh). Once installed you should be able to type `brew` in the Terminal and see how to use it.

2. Install [Git Large File Storage (git-lfs)](https://git-lfs.github.com/) with Homebrew
````
$ brew install git-lfs
````

3. Update global git config  
````
$ git lfs install
````

4. Create a Git repo to hold your Unity project folders and move any project folders into this new folder.
````
Top Level Folder
|- Unity Project 1
|- Unity Project 2
|- etc...
````
  To create your repo you can do it first on Github then clone the new repo folder and add to it or you can `git init` in your top level folder, create a new repo on Github, then add a new remote for the repo with `git remote add origin https://github.com/user/repo.git`.

5. Create .gitignore and .gitattributes files in your repo folder. Use the [Unity.gitignore template](https://github.com/github/gitignore/blob/master/Unity.gitignore). You should also include [MacOS](https://github.com/github/gitignore/blob/master/Global/macOS.gitignore) and/or [Windows](https://github.com/github/gitignore/blob/master/Global/Windows.gitignore) .gitignore templates as needed. Look at the .gitignore for this repo to see a combination of all the .gitignore templates.

6. Configure your Unity projects for Version Control. This step requires some changes to your Unity project.

  With your project open in the Unity editor:

  * Open the editor settings window.

    `Edit > Project Settings > Editor`
  
  * Make .meta files visible to avoid broken object references.
    
    `Version Control / Mode: “Visible Meta Files”`
  * Use plain text serialization to avoid unresolvable merge conflicts.
    
    `Asset Serialization / Mode: “Force Text”`
  * Save your changes.
    
    `File > Save Project`

  This will affect the following lines in your editor settings file:
    
    `ProjectSettings/EditorSettings.asset`
    `m_ExternalVersionControlSupport: Visible Meta Files`
    `m_SerializationMode: 2`
     
  If you’re curious, you can read more about Unity’s YAML scene format in the [Unity Manual](https://docs.unity3d.com/Manual/FormatDescription.html).

7. Create a .gitattributes file in the repo and add the following template.

  ````
  # 3D models
  *.3dm filter=lfs diff=lfs merge=lfs -text
  *.3ds filter=lfs diff=lfs merge=lfs -text
  *.blend filter=lfs diff=lfs merge=lfs -text
  *.c4d filter=lfs diff=lfs merge=lfs -text
  *.collada filter=lfs diff=lfs merge=lfs -text
  *.dae filter=lfs diff=lfs merge=lfs -text
  *.dxf filter=lfs diff=lfs merge=lfs -text
  *.fbx filter=lfs diff=lfs merge=lfs -text
  *.jas filter=lfs diff=lfs merge=lfs -text
  *.lws filter=lfs diff=lfs merge=lfs -text
  *.lxo filter=lfs diff=lfs merge=lfs -text
  *.ma filter=lfs diff=lfs merge=lfs -text
  *.max filter=lfs diff=lfs merge=lfs -text
  *.mb filter=lfs diff=lfs merge=lfs -text
  *.obj filter=lfs diff=lfs merge=lfs -text
  *.ply filter=lfs diff=lfs merge=lfs -text
  *.skp filter=lfs diff=lfs merge=lfs -text
  *.stl filter=lfs diff=lfs merge=lfs -text
  *.ztl filter=lfs diff=lfs merge=lfs -text
  # Audio
  *.aif filter=lfs diff=lfs merge=lfs -text
  *.aiff filter=lfs diff=lfs merge=lfs -text
  *.it filter=lfs diff=lfs merge=lfs -text
  *.mod filter=lfs diff=lfs merge=lfs -text
  *.mp3 filter=lfs diff=lfs merge=lfs -text
  *.ogg filter=lfs diff=lfs merge=lfs -text
  *.s3m filter=lfs diff=lfs merge=lfs -text
  *.wav filter=lfs diff=lfs merge=lfs -text
  *.xm filter=lfs diff=lfs merge=lfs -text
  # Fonts
  *.otf filter=lfs diff=lfs merge=lfs -text
  *.ttf filter=lfs diff=lfs merge=lfs -text
  # Images
  *.bmp filter=lfs diff=lfs merge=lfs -text
  *.exr filter=lfs diff=lfs merge=lfs -text
  *.gif filter=lfs diff=lfs merge=lfs -text
  *.hdr filter=lfs diff=lfs merge=lfs -text
  *.iff filter=lfs diff=lfs merge=lfs -text
  *.jpeg filter=lfs diff=lfs merge=lfs -text
  *.jpg filter=lfs diff=lfs merge=lfs -text
  *.pict filter=lfs diff=lfs merge=lfs -text
  *.png filter=lfs diff=lfs merge=lfs -text
  *.psd filter=lfs diff=lfs merge=lfs -text
  *.tga filter=lfs diff=lfs merge=lfs -text
  *.tif filter=lfs diff=lfs merge=lfs -text
  *.tiff filter=lfs diff=lfs merge=lfs -text
  ````
  
8. Stage all changes to the repo.
````
$ git add .
````

9. Commit all changes to the repo.
````
$ git commit -m "my message"
````

10. Push all changes to the repo.
````
$ git push
````

11. Success! Verify that the repo is updated on Github. Clone the repo and open a Unity project to verify that it runs.

Check out the following references for more information about this process. There is another project underway by Github to integrate Github into the Unity environment. You can learn more about this project [here](https://unity.github.com/).

## References

* [How to Git with Unity](https://robots.thoughtbot.com/how-to-git-with-unity)
* [Github: Adding a Remote](https://help.github.com/articles/adding-a-remote/)