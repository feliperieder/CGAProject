# CGAProject

# Trabalho Prático – Técnicas Avançadas de Computação Gráfica

## Ray Tracing, Path Tracing e Iluminação Global na Unity (HDRP)

## Descrição do Projeto

Este projeto consiste na construção de uma cena interativa utilizando a **Unity com HDRP (High Definition Render Pipeline)**, com o objetivo de demonstrar, de forma visual e prática, conceitos avançados de iluminação computacional.

A cena foi projetada para evidenciar diferenças entre **renderização em tempo real** e **Path Tracing**, destacando fenômenos como:

* Iluminação direta e indireta
* Sombras
* Reflexão especular
* Refração/transparência
* Color bleeding (iluminação global)

---

## Tecnologias Utilizadas

* Unity (HDRP)
* DirectX 12 (DXR habilitado)
* Path Tracing nativo da HDRP
* Sistema de Input moderno (Input System)

---

## Funcionalidades Implementadas

### Controle de Luz Global (Directional Light)

Foram implementados atalhos para controlar a intensidade da luz principal da cena:

* **Tecla 1** → Intensidade máxima (dia)
* **Tecla 2** → Intensidade média
* **Tecla 3** → Intensidade zero (noite)
---

### Lanterna do Jogador (Spotlight)

O usuário possui uma lanterna acoplada à câmera:

**Tecla F** → Liga/desliga a lanterna

### Controle de Cor da Lanterna

A lanterna pode ter sua cor alterada dinamicamente:

* **R** → Vermelho
* **G** → Verde
* **B** → Azul
* **E** → Branco

### Player Controlável

Foi implementado um controlador simples de jogador:

* Movimentação no espaço (WASD)
* Controle de câmera (mouse)
* Sistema de pulo (Espaço)

Permite explorar a cena livremente e observar os efeitos de iluminação de diferentes ângulos.

---

##  Efeitos de Iluminação Demonstrados

A cena foi construída para destacar os seguintes fenômenos:

### Iluminação Direta

* Múltiplas fontes de luz (Directional + Spotlight)

### Reflexão

* Superfícies metálicas e espelhadas
* Diferença entre Reflection Probes e Path Tracing

### Refração / Transparência

* Material de vidro configurado com refração
* Comportamento físico no Path Tracing

### Iluminação Indireta (Global Illumination)

* Aproximação via SSGI no tempo real
* Simulação física via Path Tracing

### Color Bleeding

* Visível principalmente no Path Tracing
* Luz refletida herdando cor das superfícies

# Physically Based Rendering (PBR)
## Materiais Metálicos e Dielétricos

Foram utilizados materiais com diferentes propriedades físicas para demonstrar o fluxo Metallic Workflow.

### Material Metálico
* Metallic = 1
* Alto Smoothness
* Reflexões intensas do ambiente
### Material Dielétrico
* Metallic = 0
* Reflexões menos intensas
* Comportamento semelhante a materiais reais como plástico, madeira e vidro

## Rugosidade (Roughness / Smoothness)
* Baixa rugosidade → Reflexões nítidas
* Alta rugosidade → Reflexões difusas

## Efeito Fresnel
O efeito Fresnel foi demonstrado através dos materiais reflexivos e transparentes.

A intensidade da reflexão aumenta conforme o ângulo de visualização se aproxima das bordas do objeto, reproduzindo o comportamento observado em materiais reais.


# HDR

## HDRI Sky
Foi utilizada uma imagem HDR para iluminação baseada em ambiente.

Benefícios observados:
* Reflexões mais realistas
* Iluminação indireta natural
* Melhor integração dos materiais com o ambiente

## Exposure
Foi implementado controle de exposição para demonstrar a influência da quantidade de luz capturada pela câmera virtual.

Foram realizados testes com diferentes valores de EV (Exposure Value):

* EV alto → imagem mais escura
* EV médio → imagem balanceada
* EV baixo → imagem mais clara

## Tone Mapping

Foi utilizado o operador ACES para conversão dos valores HDR para a faixa dinâmica suportada pelo monitor.

Benefícios:
* Preservação de detalhes em áreas muito iluminadas
* Melhor reprodução de cores
* Aparência mais cinematográfica

# Efeitos de Pós-Processamento
## Bloom

Simula o espalhamento da luz em regiões de alta intensidade luminosa.

Resultado observado:  Vazamento de luz em superfícies muito brilhantes.

## SSAO (Screen Space Ambient Occlusion)

Simula o bloqueio parcial da iluminação ambiente em regiões onde a luz indireta possui dificuldade de chegar.

Resultado observado: Maior profundidade visual, Melhor definição de contato entre objetos e superfícies

## Motion Blur

Simula o borramento causado pelo movimento da câmera ou de objetos durante o tempo de exposição.

Resultado observado: Movimento mais natural, Redução da aparência artificial durante deslocamentos rápidos

## Chromatic Aberration

Simula imperfeições ópticas presentes em lentes reais.

Resultado observado: Pequena separação dos canais RGB nas bordas da imagem
