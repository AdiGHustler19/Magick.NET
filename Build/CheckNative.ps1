$files = git diff --name-only HEAD~1 HEAD

if ($files -contains "ImageMagick/Source/ImageMagick.commit") {
    Write-Host "##vso[task.setvariable variable=BuildNative;isOutput=true]true"
}