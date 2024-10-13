# Base64 File Encoder/Decoder

This repository contains a simple C# console application that encodes files into Base64 format or decodes Base64-encoded files back to their original format. This tool is useful for working with file conversions in a variety of use cases, such as sending binary files as text or decoding Base64 files to restore the original content.

## Features

- **Encode** any file into a Base64-encoded string.
- **Decode** Base64-encoded files back to their original binary format.
- Automatically determines if the input file is already Base64 encoded.
- Saves the Base64-encoded file with a `+base64.txt` extension.
- Decodes the Base64-encoded file and saves it with the original file extension.

## Usage

### Encoding a File to Base64
1. Pass the file path as an argument to the program.
2. The program will read the file, convert it to Base64, and save it with the same name in the same directory but with a `+base64.txt` suffix.

### Decoding a Base64-encoded File
1. If the input file is already Base64 encoded, the program will decode it.
2. The decoded file will be saved with the original file extension and the suffix `_decoded` in the same directory.

### Example Commands

```bash
# Encode a file
Program.exe "C:\path\to\your\file.txt"

# Decode a Base64-encoded file
Program.exe "C:\path\to\your\file+base64.txt"
