# .NET HTTP Request in Unity

This is a Unity project that demonstrates how to make HTTP requests using the `HttpClient` class from .NET. The project includes a `Player` class that makes an HTTP request to a specified URL when it collides with a game object with a specific tag.

## Installation

1. Clone the repository to your local machine using `git clone https://github.com/emirariemir/dotNET-HTTP-Request-Unity.git`.
2. Open the project in Unity.

## Usage

1. Attach the `Player` script to a game object in your scene.
2. Set the `API_URL` constant in the `Player` script to the URL you want to send the HTTP request to.
3. Add a game object to your scene with the tag `call-box`, or change the tag, whatever.
4. When the `Player` collides with the `call-box` object, an HTTP request will be sent to the specified URL.

## Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://github.com/emirariemir/dotNET-HTTP-Request-Unity/blob/main/LICENSE)
