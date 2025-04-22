# dotnet

## DemoMcpClientServer

### Run DemoMcpServer locally (stdio) with [MCP Inspector](https://github.com/modelcontextprotocol/inspector)

#### Start the inspector:

```shell
npx @modelcontextprotocol/inspector
```

#### Connect:

- Transport type: STDIO
- Command: dotnet
- Arguments: `run --project <path-to-project>/DemoMcpServer/DemoMcpServer.csproj --no-build`

_`path-to-project`: relative, if the inspector started in project folder, absolute for anywhere else._

### VS Code integration

Edit `settings.json` to include the following:

```json
"mcp": {
    "inputs": [],
    "servers": {
        "dotnet-demo-server": {
            "command": "dotnet",
            "args": [
            "run",
            "--project",
            "<absolute-path-to-project>DemoMcpServer/DemoMcpServer.csproj",
            "--no-build"
        ],
        "env": {}
       }
    }
}
```
