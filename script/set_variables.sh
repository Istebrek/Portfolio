#!/bin/bash

echo Setting environment variables..

export SUBSCRIPTION_ID="90ba2334-6225-41f6-90ca-3e14c838730e"

export SERVICE_CONNECTION="sc-portfolio-proj"

export PROJECT="portfolio"
export APPLICATION="ui"
export TAG="latest"

export ACR_NAME="istebreksacr"
export TAGGED_IMAGE="$PROJECT:$TAG"
export ACR_IMAGE="$ACR_NAME.azurecr.io/$TAGGED_IMAGE"