
# Base64 File Encoder/Decoder

This C# program encodes or decodes files using Base64. The input file is read from a folder named `files`, and the result is saved in the same directory.

- If the file is a regular binary file, the program encodes it into Base64 and saves the output as `<original_filename>+base64.txt`.
- If the file is already Base64-encoded, the program decodes it and restores the original file with a `_decoded` suffix in its name.

## Folder Structure
- `files/`: This folder contains both input files and the generated Base64-encoded or decoded files.

## Features
- **Base64 Encoding**: Converts the content of a binary file into a Base64 string and saves it in the same directory.
- **Base64 Decoding**: Detects if a file is already Base64-encoded and decodes it back into its original form.

## How to Use

1. Place the file you want to encode or decode in the `files/` folder.
2. Run the program, providing the file name as an argument:
   ```bash
   dotnet run "yourfile.ext"
   ```

3. Depending on the file type:
   - If the file is not Base64, the program encodes it and saves the output as `yourfile+base64.txt` in the `files` folder.
   - If the file is Base64-encoded, the program decodes it and saves the decoded file as `yourfile_decoded.ext` in the same `files` folder.

## Example

1. Place a file called `example.txt` inside the `files` folder.
2. Run the program:
   ```bash
   dotnet run "example.txt"
   ```
3. The program will check if `example.txt` is Base64-encoded or not:
   - If not, it will encode the file and save `example+base64.txt`.
   - If it is already Base64, it will decode it and save `example_decoded.txt`.

## Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

## License
This project is licensed under the MIT License.
