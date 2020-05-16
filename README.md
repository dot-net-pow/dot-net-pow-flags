# .Net Pow! Flags

The goal of this project was to make it flexible and turn-key for using flag icons in web solutions providing
options that allow developers to display icons in a variety of ways depending on development needs. 

> **Heads Up:** Are currently updating to include some of the features described below and getting it packaged for
> - Npm 
> - Nuget
> 
> We wanted to get this out so for now downloading will have to do!

<br>

## Countries
If your project only requires country flags, ***i.e., you don't localize with culture specific translations like en-US or en-GB*** 
or map languages to a single flag *(English: us, gb, etc.; Spanish: mx, ni, etc.)*, use **dot-net-pow-flags-country.css**. 

>Note: If you only need one of the options or don't need or want/care about verbosity or just want a smaller *.css file, they are also available separately:
>- **dot-net-pow-flags-country-short.css** *(name, iso2-short, iso3-short)*
>- **dot-net-pow-flags-country-name.css**
>- **dot-net-pow-flags-country-iso2.css** 
>- **dot-net-pow-flags-country-iso2-short.css** 
>- **dot-net-pow-flags-country-iso3.css**
>- **dot-net-pow-flags-country-iso3-short.css** 

<br>

### 2-digit ISO Country Code 
```html
<!-- Verbose -->
<div class="dot-net-pow-flags country-iso2-us"></div>

<!-- Short -->
<div class="dot-net-pow-flags us"></div>
```
<br>

### 3-digit ISO Country Code
```html
<!-- Verbose -->
<div class="dot-net-pow-flags country-iso3-usa"></div>

<!-- Short -->
<div class="dot-net-pow-flags usa"></div>
```
<br>

### ISO Country Name *(lower case, spaces and periods replaced with hyphens)*
```html
<div class="dot-net-pow-flags united-states"></div>
```

<br>
<br>

# Culture Specific
If you project requires culture specific options, use **dot-net-pow-flags-country-language.css**.
This has all of the CSS classes from the **dot-net-pow-flags-country.css** file and includes the 
language specific additions. Similarly, if you don't want or care to use verbosity or want smaller *.css files:

>- **dot-net-pow-flags-country-language-short.css**
>- **dot-net-pow-flags-country-iso2-language-iso2.css** 
>- **dot-net-pow-flags-country-iso2-language-iso2-short.css** 
>- **dot-net-pow-flags-country-iso3-language-iso2.css-short.css**
>- **dot-net-pow-flags-country-iso2-language-iso3.css-short.css**
>- **dot-net-pow-flags-country-iso3-language-iso3.css-short.css**  

<br>

### 2 or 3-digit ISO Country Code and 2 or 3-digit ISO Language Code
```html
<!-- Verbose -->
<div class="dot-net-pow-flags country-iso2-us-language-iso2-en"></div>

<!-- Short -->
<div class="dot-net-pow-flags us-en"></div>
```
<br>

### 2 or 3-digit ISO Language Code and 2 or 3-digit ISO Country Code
```html
<!-- Verbose -->
<div class="dot-net-pow-flags language-iso2-en-country-iso2-us"></div>

<!-- Short -->
<div class="dot-net-pow-flags en-us"></div>
```

<br>
<br>

# Images

All of the flag images are available and supplied from [Flagpedia](https://flapedia.net/download) and available in **PNG**, **WebP** and **JPEG** formats 
with resolutions by width or height. **.Net Pow! Flags** uses the `*.png`files. 

<br>

### Size Variations
All of the styles include additional classes that can be used to vary the image resolution and size by width or height, or to stretch the images
to uniform heights and widths. With this initial release images are set to the same size and stretched

```html
<!-- 18px width, 12px height -->
<div class="dot-net-pow-flags us w18"></div>

<!-- 24px width, 16px height -->
<div class="dot-net-pow-flags us w24"></div>

<!-- 36px width, 24px height -->
<div class="dot-net-pow-flags us w36"></div>

<!-- 48px width, 32px height -->
<div class="dot-net-pow-flags us w48"></div>

<!-- 64px width, 42px height -->
<div class="dot-net-pow-flags us w64"></div>

<!-- 128px width, 86px height -->
<div class="dot-net-pow-flags us w1s8"></div>

<!-- 320px width, 214px height -->
<div class="dot-net-pow-flags us w320"></div>
```


<br>
<br>

## License

See [License](https://github.com/dot-net-pow/dot-net-pow-flags/master/LICENSE.md)