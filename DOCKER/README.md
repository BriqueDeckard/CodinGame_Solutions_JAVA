# WSL+Docker: Kubernetes on the Windows Desktop: 
<details>
	<summary>Sources:</summary>https://kubernetes.io/blog/2020/05/21/wsl-docker-kubernetes-on-the-windows-desktop/</details>


## Prerequisites: 

Since we will explain how to install KinD, we won't go into too much detail around the installation of KinD's dependencies.

However, here is the list of the prerequisites needed and their version/lane:

OS: Windows 10 version 2004, Build 19041
WSL2 enabled
In order to install the distros as WSL2 by default, once WSL2 installed, run the command wsl.exe --set-default-version 2 in Powershell
WSL2 distro installed from the Windows Store - the distro used is Ubuntu-18.04
Docker Desktop for Windows, stable channel - the version used is 2.2.0.4
[Optional] Microsoft Terminal installed from the Windows Store
Open the Windows store and type "Terminal" in the search, it will be (normally) the first option
Windows Store Terminal

And that's actually it. For Docker Desktop for Windows, no need to configure anything yet as we will explain it in the next section.

## WSL2: First contact: 

Once everything is installed, we can launch the WSL2 terminal from the Start menu, and type "Ubuntu" for searching the applications and documents:

Once found, click on the name and it will launch the default Windows console with the Ubuntu bash shell running.

Like for any normal Linux distro, you need to create a user and set a password:

## Update Ubuntu: 

Before we move to the Docker Desktop settings, let's update our system and ensure we start in the best conditions:

Update the repositories and list of the packages available :
```
sudo apt update
```

Update the system based on the packages installed > the "-y" will approve the change automatically :
```
sudo apt upgrade -y
```

## Docker Desktop: faster with WSL2: 
Before we move into the settings, let's do a small test, it will display really how cool the new integration with Docker Desktop is:

Try to see if the docker cli and daemon are installed
```
docker version
```

Same for kubectl
```
kubectl version
```

You got an error? Perfect! It's actually good news, so let's now move on to the settings

## Docker Desktop settings: enable WSL2 integration: 

First let's start Docker Desktop for Windows if it's not still the case. Open the Windows start menu and type "docker", click on the name to start the application.

One in the application, click on "settings" and click the "Enable the experimental WSL 2 based engine" and click "Apply & Restart".

What this feature did behind the scenes was to create two new distros in WSL2, containing and running all the needed backend sockets, daemons and also the CLI tools (read: docker and kubectl command).

Still, this first setting is still not enough to run the commands inside our distro. If we try, we will have the same error as before.

In order to fix it, and finally be able to use the commands, we need to tell the Docker Desktop to "attach" itself to our distro also.

Let's now switch back to our WSL2 terminal and see if we can (finally) launch the commands:

### Try to see if the docker cli and daemon are installed
#### Docker: 
##### Command: 
```
docker version
```
##### Answer: 
```
Client: Docker Engine - Community
 Cloud integration: 1.0.17
 Version:           20.10.8
 API version:       1.41
 Go version:        go1.16.6
 Git commit:        3967b7d
 Built:             Fri Jul 30 19:54:22 2021
 OS/Arch:           linux/amd64
 Context:           default
 Experimental:      true

Server: Docker Engine - Community
```
#### Kubectl:
##### Command: 
```
kubectl version
```
##### Answer:
```
Client Version: version.Info{Major:"1", Minor:"21", GitVersion:"v1.21.5", GitCommit:"aea7bbadd2fc0cd689de94a54e5b7b758869d691", GitTreeState:"clean", BuildDate:"2021-09-15T21:10:45Z", GoVersion:"go1.16.8", Compiler:"gc", Platform:"linux/amd64"}
The connection to the server localhost:8080 was refused - did you specify the right host or port?
```

## KinD: Kubernetes made easy in a container

Right now, we have Docker that is installed, configured and the last test worked fine.

However, if we look carefully at the kubectl command, it found the "Client Version" (1.15.5), but it didn't find any server.

This is normal as we didn't enable the Docker Kubernetes cluster. So let's install KinD and create our first cluster.

And as sources are always important to mention, we will follow (partially) the how-to on the official KinD website:


Download the latest version of KinD
```
curl -Lo ./kind https://github.com/kubernetes-sigs/kind/releases/download/v0.7.0/kind-linux-amd64
```

Make the binary executable
```
chmod +x ./kind
```

Move the binary to your executable path
```
sudo mv ./kind /usr/local/bin/
```

### KinD: the first cluster

We are ready to create our first cluster:


Check if the KUBECONFIG is not set: 
```
echo $KUBECONFIG
```
Answer: 
```

```

Check if the .kube directory is created > if not, no need to create it: 
```
ls $HOME/.kube
```
Answer: 
```
ls: cannot access '/home/brique/.kube': No such file or directory
```

Create the cluster and give it a name (optional): 
```
kind create cluster --name wslkind
```

Check if the .kube has been created and populated with files: 
```
ls $HOME/.kube
```

Check if the .kube directory is created > if not, no need to create it: 
```
ls $HOME/.kube
```

Create the cluster and give it a name (optional)
```
kind create cluster --name wslkind
```
If something turn wrong and you have to delete the cluster, the command is: 
```
kind delete cluster --name wslkind
```
Finally, check if the .kube has been created and populated with files: 
```
ls $HOME/.kube
```

The cluster has been successfully created, and because we are using Docker Desktop, the network is all set for us to use "as is".

### KinD: counting 1 - 2 - 3

Our first cluster was created and it's the "normal" one node cluster:

Check how many nodes it created:
```
kubectl get nodes
```
Answer: 
```
NAME                    STATUS   ROLES    AGE     VERSION
wslkind-control-plane   Ready    master   4m59s   v1.17.0
```

Check the services for the whole cluster: 
```
kubectl get all --all-namespaces
```
Answer:
```
NAMESPACE            NAME                                                READY   STATUS    RESTARTS   AGE
kube-system          pod/coredns-6955765f44-hvb9w                        1/1     Running   0          5m14s
kube-system          pod/coredns-6955765f44-vtfz4                        1/1     Running   0          5m14s
kube-system          pod/etcd-wslkind-control-plane                      1/1     Running   0          5m9s
...
```

Delete the existing cluster
```
kind delete cluster --name wslkind
```

Create a config file for a 3 nodes cluster
```
cat << EOF > kind-3nodes.yaml
kind: Cluster
apiVersion: kind.x-k8s.io/v1alpha4
nodes:
  - role: control-plane
  - role: worker
  - role: worker
EOF
```

Create a new cluster with the config file
```
kind create cluster --name wslkindmultinodes --config ./kind-3nodes.yaml
```

Check how many nodes it created
```
kubectl get nodes
```
Answer:
```
NAME                              STATUS   ROLES    AGE    VERSION
wslkindmultinodes-control-plane   Ready    master   103s   v1.17.0
wslkindmultinodes-worker          Ready    <none>   58s    v1.17.0
wslkindmultinodes-worker2         Ready    <none>   58s    v1.17.0
```

And that's it, we have created a three-node cluster, and if we look at the services one more time, we will see several that have now three replicas:

Check the services for the whole cluster
```
kubectl get all --all-namespaces
```

### KinD: can I see a nice dashboard?

Working on the command line is always good and very insightful. However, when dealing with Kubernetes we might want, at some point, to have a visual overview.

For that, the Kubernetes Dashboard project has been created. The installation and first connection test is quite fast, so let's do it:

Install the Dashboard application into our cluster: 
```
kubectl apply -f https://raw.githubusercontent.com/kubernetes/dashboard/v2.0.0-rc6/aio/deploy/recommended.yaml
```
Check the resources it created based on the new namespace created
```
kubectl get all -n kubernetes-dashboard
```

As it created a service with a ClusterIP (read: internal network address), we cannot reach it if we type the URL in our Windows browser. That's because we need to create a temporary proxy:

Start a kubectl proxy: 
```
kubectl proxy
```

Finally to login, we can either enter a Token, which we didn't create, or enter the kubeconfig file from our Cluster.

If we try to login with the kubeconfig, we will get the error "Internal error (500): Not enough data to create auth info structure". This is due to the lack of credentials in the kubeconfig file.

So to avoid you ending with the same error, let's follow the recommended RBAC approach.

Let's open a new WSL2 session:

Create a new ServiceAccount
```
kubectl apply -f - <<EOF
apiVersion: v1
kind: ServiceAccount
metadata:
  name: admin-user
  namespace: kubernetes-dashboard
EOF
```
Create a ClusterRoleBinding for the ServiceAccount
```
kubectl apply -f - <<EOF
apiVersion: rbac.authorization.k8s.io/v1
kind: ClusterRoleBinding
metadata:
  name: admin-user
roleRef:
  apiGroup: rbac.authorization.k8s.io
  kind: ClusterRole
  name: cluster-admin
subjects:
- kind: ServiceAccount
  name: admin-user
  namespace: kubernetes-dashboard
EOF
```

Get the Token for the ServiceAccount
```
kubectl -n kubernetes-dashboard describe secret $(kubectl -n kubernetes-dashboard get secret | grep admin-user | awk '{print $1}')
```
Then copy the token and copy it into the Dashboard login and press "Sign in"

## Minikube: Kubernetes from everywhere
Right now, we have Docker that is installed, configured and the last test worked fine.

However, if we look carefully at the kubectl command, it found the "Client Version" (1.15.5), but it didn't find any server.

This is normal as we didn't enable the Docker Kubernetes cluster. So let's install Minikube and create our first cluster.

And as sources are always important to mention, we will follow (partially) the how-to from the Kubernetes.io website:

Download the latest version of Minikube
```
curl -Lo minikube https://storage.googleapis.com/minikube/releases/latest/minikube-linux-amd64
```
Make the binary executable
```
chmod +x ./minikube
```
Move the binary to your executable path
```
sudo mv ./minikube /usr/local/bin/
```