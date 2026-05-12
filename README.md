# TCP Demo App (Server & Client)

[![Build C# WinForms app](https://github.com/iqfareez/TCP-App/actions/workflows/build-app.yml/badge.svg)](https://github.com/iqfareez/TCP-App/actions/workflows/build-app.yml)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This is a simple TCP demo application consisting of a server and a client, developed using C# .NET WinForms. 
The solution contains two projects: **TCP-Client** and **TCP-Server**. The server and client communicate with each 
other over a TCP/IP connection, allowing them to exchange messages in real-time.

![screenshot tcp demo server and clients](https://imgur.com/lGQr5Jq.png)

## Features

- **Real-time communication**: Send and receive messages instantly over TCP/IP.
- **Cross-device connection**: Connect a client and server on the same machine (localhost) or across different devices on the same local network.
- **User-friendly interface**: Simple and intuitive Windows Forms GUI for both server and client.

## Getting Started

1. Clone the repository to your local machine:
   ```bash
   git clone https://github.com/iqfareez/TCP-App.git
   ```
2. Open the solution `TCP-App.sln` in Visual Studio or JetBrains Rider.
3. Build and run both the **TCP-Server** and **TCP-Client** projects.

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://imgur.com/DvSv2Om.png">
  <img alt="Localhost diagram" src="https://imgur.com/5VIao5v.png">
</picture>

### Connecting Client and Server on the same machine

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://imgur.com/HJzf7NX.png">
  <img alt="Localhost diagram" src="https://imgur.com/UcQpTxf.png">
</picture>

The client and server are configured to connect to each other using the loopback address.

![screenshot localhost setup](https://imgur.com/viwIKcw.png)

> **Note** `localhost` can also be referenced by the loopback IP address `127.0.0.1`. This IP is fixed.

In the TCP Server app, click the `Start Server` button to start the server. In the TCP Client app, click the `Connect` button to connect to the server.
Now, you can start sending messages between the client and server.

### Connecting Client and Server on different machines

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://imgur.com/v0lkClj.png">
  <img alt="Local network diagram" src="https://imgur.com/fOL8DMC.png">
</picture>

In this section, I will be using Android since I don't have an extra laptop to test this out. Feel free to use any other TCP Client on any device.

Download the [TCP Client](https://play.google.com/store/apps/details?id=com.hardcodedjoy.tcpclient) app from the Google Play Store.

Please ensure that both devices are connected **to the same local network (Wi-Fi)**.

![wifi same network](https://imgur.com/b5ghPyY.png)

From the TCP Server app, start the server. Notice there is host:port information in the "On your network" section.

![tcps erver app](https://imgur.com/lYayO93.png)

> **Note** Your PC local IP address can also be found by running `ipconfig` in the command prompt.

On your Android device, open the TCP Client app and enter the host and port information from the server app.

![tcp client setting](https://imgur.com/osAySn0.png)

Now, you can start sending messages between the client and server.

![tcp client connected](https://imgur.com/tttJfmw.png)

**Demo:**

https://github.com/iqfareez/TCP-App/assets/60868965/738f869e-bdec-4e00-b0a3-39a1017b8ace

### Bonus: LED Demo

This is a bonus demo to show how the client can control the virtual 'LED' on the server.

[led tcp demo.webm](https://github.com/iqfareez/TCP-App/assets/60868965/ed0739b3-36ef-4126-9ba5-6fd7529f4a41)

## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

Please read our [Contributing Guidelines](CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## Releases

See the [Releases](https://github.com/iqfareez/TCP-App/releases) page for pre-built binaries.

Alternatively, you can fork this repo and run the GitHub Action workflow [`Build C# WinForms app`](https://github.com/iqfareez/TCP-App/actions/workflows/build-app.yml) to automatically build the artifacts.

## Check this out

- CLI version of TCP Server and Client: [ConsoleApp2-TCP](https://github.com/iqfareez/MCTE-4327-Software-Engineering/tree/main/ConsoleApp2-TCP)
- For Software Engineering notes, go to: [MCTE-4327-Software-Engineering](https://github.com/iqfareez/MCTE-4327-Software-Engineering/)
- Chat App C# Project from a previous semester student: [Chat-Application](https://github.com/zulhafiz-zulkifli/Chat-Application) (their chat UI is beautiful)

## References

- [TCP Listener](https://learn.microsoft.com/en-us/dotnet/api/system.net.sockets.tcplistener)
- [TCP Client](https://learn.microsoft.com/en-us/dotnet/api/system.net.sockets.tcpclient)
- ChatGPT

