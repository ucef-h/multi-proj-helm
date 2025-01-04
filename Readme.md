## Helm Location
https://ucef-h.github.io/multi-proj-helm/index.yaml

### **Helm Basics**
1. **`helm create <chart-name>`**  
   Create a new Helm chart with a starter template.

2. **`helm lint <chart-path>`**  
   Check a Helm chart for syntax errors and best practices.

3. **`helm dependency update`**  
   Fetch and update dependencies specified in `Chart.yaml`.

4. **`helm dependency list`**  
   List the dependencies of a chart and their current status.

5. **`helm package <chart-path>`**  
   Package a Helm chart into a `.tgz` file for distribution.

6. **`helm repo add <name> <url>`**  
   Add a Helm repository by providing a name and URL.

7. **`helm repo update`**  
   Refresh the local cache of Helm chart repositories.

8. **`helm search repo <keyword>`**  
   Search for charts in all added Helm repositories.

9. **`helm show values <chart-name>`**  
   Display the default `values.yaml` for a Helm chart.

---

### **Chart Rendering and Testing**
10. **`helm template <release-name> <chart-path>`**  
    Render the Helm templates into raw Kubernetes YAML without deploying.

11. **`helm install <release-name> <chart-path>`**  
    Install a chart into the Kubernetes cluster as a named release.

12. **`helm upgrade <release-name> <chart-path>`**  
    Upgrade an existing release to use a newer chart version or updated values.

13. **`helm rollback <release-name> <revision>`**  
    Roll back a release to a previous revision.

14. **`helm uninstall <release-name>`**  
    Uninstall a Helm release from the Kubernetes cluster.

15. **`helm get values <release-name>`**  
    Retrieve the values currently applied to a release.

16. **`helm get manifest <release-name>`**  
    Display the rendered Kubernetes resources for a release.

17. **`helm get notes <release-name>`**  
    Show the post-installation notes for a release.

18. **`helm list`**  
    List all deployed releases in the current Kubernetes namespace.

19. **`helm history <release-name>`**  
    Show the revision history of a Helm release.

20. **`helm test <release-name>`**  
    Run tests (if defined) for a Helm release.

---

### **Value Overrides**
21. **`helm install <release-name> <chart-path> --set <key>=<value>`**  
    Override values directly from the command line.

22. **`helm install <release-name> <chart-path> -f <values-file>`**  
    Use a custom `values.yaml` file to override default chart values.

23. **`helm upgrade <release-name> <chart-path> --reuse-values`**  
    Upgrade a release while reusing the currently applied values.

---

### **Debugging and Cleanup**
24. **`helm lint <chart-path> --debug`**  
    Perform a lint check with verbose output for troubleshooting.

25. **`helm install <release-name> <chart-path> --dry-run --debug`**  
    Simulate an installation and show detailed output without applying it.

26. **`helm uninstall <release-name> --keep-history`**  
    Uninstall a release but retain its history for potential rollback.

27. **`helm template <chart-path> --output-dir <dir>`**  
    Render chart templates and save the Kubernetes manifests to a directory.

28. **`helm delete --purge <release-name>`** (Helm v2 only)  
    Delete a release and its history (deprecated in Helm 3).

---

### **Chart Repositories**
29. **`helm repo list`**  
    List all added Helm repositories.

30. **`helm repo remove <name>`**  
    Remove a Helm repository from the local configuration.

---