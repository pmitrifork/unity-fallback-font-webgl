# unity-fallback-font-webgl
Sample project showing problem with Unity fallback fonts. The app shows two texts with Japanese characters. First using font with Japanese font set as fallback font. Second using the fallback font directly.

Regular: サポ (with font Roboto-Regular.ttf)
Fallback:サポ (with font Roboto-Regular-With-Fallback.ttf)

Font Roboto-Regular includes a reference to font Roboto-Regular-With-Fallback.

Steps to reproduce:
- Run in editor to see two texts with Japanese characters
- Build and run on WebGL platform and the app would only show the second text with Japanese characters, while the first text would only include Latin characters

