# Network Extensions for Godot Engine (3.3.3, C#)

Extensions methods and static methods for networking in Godot Engine.

## How to install

Use `git` submodules: open a command prompt in your project folder and then:

```
git submodule add https://github.com/Srynetix/godot-plugin-networkext addons/networkext
```

It requires the `Newtonsoft.Json` NuGet package in your project:

```
dotnet add package Newtonsoft.Json --version 13.0.1
```

## How to use

### NetworkExt

```cs
/// Convert any C# object to JSON.
string ToJson(this object obj);
/// => var jsonString = myObjectInstance.ToJson();

/// Convert JSON string to any C# object.
T FromJson<T>(string data);
/// => var myObjectInstance = NetworkExt.FromJson<MyObject>(jsonString)

/// Check if the current tree is a network server, even
/// without a NetworkPeer.
bool IsNetworkServer(SceneTree tree);

/// Check if the current tree is a network master, even
/// without a NetworkPeer.
bool IsNetworkMaster(Node node);

/// Check if networking is enabled, even without a
/// NetworkPeer.
bool IsNetworkEnabled(SceneTree tree);

/// Check if the current tree is a network server, even
/// without a NetworkPeer, extension method version.
bool IsNetworkServerChecked(this SceneTree tree);

/// Check if the current tree is a network master, even
/// without a NetworkPeer, extension method version.
bool IsNetworkMasterChecked(this Node node);
```