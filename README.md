# What?

* プロジェクト全体に関わる設定を管理するためのアセットのクラスです。

# Why?

* 複数プロジェクトで利用することが想定されるので、実装しました。
* また、サブプロジェクトとメインプロジェクトを判定する必要があるため、フィールドを実装しています。
    * SceneNameResolver 的なクラスでサブの時とメインの時とでパスを読み替える必要があったりします。

# Install

```shell
$ npm install github:kidsstar/setting_project.git
```

# Usage

```csharp
using UnityEngine;
using UnityModule.Settings;

class Sample : MonoBehaviour {

    void Start() {
        if (ProjectSetting.Instance.IsMain) {
            Debug.Log("メイン！");
        } else {
            Debug.Log("サブ！");
        }
    }

}

```

1. メニューの Assets &gt; Create &gt; Settings &gt; ProjectSetting を選びます
1. `Assets/Resources/Settings/ProjectSetting.asset` が生成されます。
1. プロジェクトの種別に応じて `Is Main` の値を変更してください。
1. `Priority` は、メインの時は1、サブの時は0を設定してください。
  * メインが最も高い値であれば何でも構いません。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

