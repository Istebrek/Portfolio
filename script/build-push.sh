#!/bin/bash

set -euo pipefail

# set variable values for envitonment
source ./set_variables.sh

docker buildx build -t $ACR_IMAGE .

az account set --subscription "$ACR_SUBSCRIPTION_ID"
az acr login -n $ACR_NAME

docker push $ACR_IMAGE